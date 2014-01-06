(function () {
    'use strict';

    var serviceId = 'datacontext';
    angular.module('app').factory(serviceId,
        ['common', 'entityManagerFactory', 'config', datacontext]);

    function datacontext(common, emFactory, config) {

        var EntityQuery = breeze.EntityQuery;
        var manager = emFactory.newManager();

        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(serviceId);

        var logError = getLogFn(serviceId, 'error');
        var logSuccess = getLogFn(serviceId, 'success');

        var primePromise;

        var searchPredicates;

        var $q = common.$q;

        var storeMeta = {
            isLoaded: {
                sessions: false,
                attendees: false
            }
        };

        var entityNames = {
            Transaccao: 'CabecalhoTransaccoesBrief'
        }

        var service = {
            getTransaccoes: getTransaccoes,
            getMessageCount: getMessageCount,
            getPeople: getPeople,
            getFilteredCount: getFilteredCount,
            getTransaccoesCount: getTransaccoesCount,
            setCriterioPesquisa: setCriterioPesquisa

            // prime: prime
        };



        return service;

        //function prime() {
        //    if (primePromise) return primePromise;

        //    primePromise = $q.all([getLookups(), getSpeakerPartials()])
        //        .then(extendMetadata)
        //        .then(success);
        //    return primePromise

        //    function success() {

        //        setLookups();
        //        log('Primed the data');
        //    }

        //}

        function setDates(offset) {

            var time = new Date();
            time.setDate(time.getDate() + offset);

            return time;
        }


        function setCriterioPesquisa(criterios) {
            // var criterios = vm.criterios;

            //searchPredicates = breeze.Predicate.create('ctClienteID', 'contains', criterios.wildCard)
            //                    .or('conta.cDesgn_Com', 'contains', criterios.wildCard)
            //                    .or('ctGuiaID', 'contains', criterios.wildCard)

            var p1 = breeze.Predicate.create('ctClienteID', 'contains', criterios.wildCard);
            var p2 = breeze.Predicate.create('dCom', 'contains', criterios.wildCard);
            var p3 = breeze.Predicate.create('ctGuiaID', 'contains', criterios.wildCard);


            var pred = breeze.Predicate.or([p1, p2, p3])
            searchPredicates = pred;

            //  if (criterios.dataFim && criterios.dataInicio) {

            var p4 = breeze.Predicate.create('ctDataFim', '>=', new Date(moment(criterios.dataInicio || setDates(-15)).format('YYYY,MM,DD')));
            var p5 = breeze.Predicate.create('ctDataFim', '<=', new Date(moment(criterios.dataFim || setDates(0)).format('YYYY,MM,DD')));

            var predFinal = pred.and([p4, p5]);
            searchPredicates = predFinal;

            //  }

        }

        function _getAllLocal(resource, ordering, predicate) {

            return EntityQuery.from(resource)
                    .orderBy(ordering)
                    .where(predicate)
                    .using(manager)
                    .executeLocally();
        }


        function getMessageCount() { return $q.when(72); }

        function getPeople() {
            var people = [
                { firstName: 'John', lastName: 'Papa', age: 25, location: 'Florida' },
                { firstName: 'Ward', lastName: 'Bell', age: 31, location: 'California' },
                { firstName: 'Colleen', lastName: 'Jones', age: 21, location: 'New York' },
                { firstName: 'Madelyn', lastName: 'Green', age: 18, location: 'North Dakota' },
                { firstName: 'Ella', lastName: 'Jobs', age: 18, location: 'South Dakota' },
                { firstName: 'Landon', lastName: 'Gates', age: 11, location: 'South Carolina' },
                { firstName: 'Haley', lastName: 'Guthrie', age: 35, location: 'Wyoming' }
            ];
            return $q.when(people);
        }


        function getTransaccoes(forceRemote, page, size, nameFilter) {


            var orderBy = 'ctDataFim desc, ctClienteID';
            //  var transaccoes = [];

            var take = size || 20;
            var skip = page ? (page - 1) * size : 0;

            if (_areTransLoaded() && !forceRemote) {
                return $q.when(getByPage());

            }

            //var count = EntityQuery.from('CabecalhoBrief')
            //       .where(searchPredicates)
            //       .orderBy(orderBy)
            //      .inlineCount(true)
            //       .using(manager).execute();
         


               
            return EntityQuery.from('CabecalhoBrief')//.expand(['Conta'])
                                .take(1000)
                                .where(searchPredicates)
                                .orderBy(orderBy)
                                // .select('ctGuiaID,ctTipoTran,ctDataFim,conta')
                                .toType('CabecalhoTransaccoesBrief')
                                .using(manager).execute()
                                .to$q(querySucceeded, _queryFailed);
             


            function getByPage() {

                _resetCriterios();

                var predicate = null;
                if (nameFilter) {
                    predicate = _nomePredicate(nameFilter).and(searchPredicates);
                }
                else
                    predicate = searchPredicates;

                var transaccoes = EntityQuery
                .from('CabecalhoBrief')
                .take(1000)
                .where(predicate)
                .take(take)
                .skip(skip)
                .orderBy(orderBy)
                .toType('CabecalhoTransaccoesBrief')
                .using(manager).executeLocally();

                return transaccoes;

            }

            function querySucceeded(data) {


                //transaccoes = data.results;
                //_areSpeakersLoaded(true);
                _areTransLoaded(true);
                log('Retried [Transacções Parciais] from remote data source', data.results.length, true);
                return getByPage();
            }

        }

        function getFilteredCount(nameFilter) {

            _resetCriterios();

            var predicate = _nomePredicate(nameFilter).and(searchPredicates)

            var transaccoes = EntityQuery
               .from('CabecalhoBrief')
               .where(predicate)
               .toType('CabecalhoTransaccoesBrief')
               .using(manager)
               .executeLocally();
            return transaccoes.length;
        }

        function getTransaccoesCount() {
            if (_areTransLoaded()) {
                return $q.when(_getLocalEntityCount(entityNames.Transaccao));
            }

            return EntityQuery.from(entityNames.Transaccao)
                    .using(manager).execute()
                    .to$q(_getInlineCount);
        }

        function _getLocalEntityCount(resource) {

            _resetCriterios();

            var entities = EntityQuery.from(resource)
            .where(searchPredicates)
            .using(manager)
            .executeLocally();

            return entities.length;
        }

        function _getInlineCount(data) { return data.inlineCount; }

        function _nomePredicate(filterValue) {

            return breeze.Predicate.create('dCom', 'contains', filterValue)
                                          .or('ctGuiaID', 'contains', filterValue)
                                          .or('ctTipoTran', 'contains', filterValue)
            //.or('ctDataFim', 'contains', new Date(filterValue))

            ;
        }

        function _queryFailed(error) {
            var msg = config.appErrorPrefix + 'Error retrieving data. ' + error.message;
            logError(msg, error);
            throw error;
        }

        function _areTransLoaded(value) {
            return _areItemsLoaded('CabecalhoTransaccoes', value)
        }

        function _areItemsLoaded(key, value) {
            if (value === undefined) {
                return storeMeta.isLoaded[key];
            }

            return storeMeta.isLoaded[key] = value;
        }

        function _resetCriterios() {

            if (!searchPredicates) {
                var criterios = {
                    wildCard: ''//,
                    //dataInicio: new Date('2000-01-01'),
                    //dataFim: new Date('2015-12-31')
                }

                setCriterioPesquisa(criterios);
            }
        }
    }
})();