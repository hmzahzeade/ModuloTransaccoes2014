(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'transaccoes';

    // Define the controller on the module.
    // Inject the dependencies. 
    // Point to the controller definition function.
    angular.module('app').controller(controllerId,
        ['common', 'datacontext', 'config', transaccoes]);

    function transaccoes(common, datacontext, config) {
        // Using 'Controller As' syntax, so we assign this to the vm variable (for viewmodel).
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);
        var vm = this;

        var keyCodes = config.keyCodes;

        var totalPaginas;
        // Bindable properties and functions are placed on vm.
        vm.activate = activate;
        vm.title = 'Transaccoes';
        vm.refresh = refresh;
        vm.transaccoes = [];

        //filtros e coisas bonitas assim
        vm.transaccoesCount = 0;
        vm.transaccoesFilteredCount = 0;
        vm.transaccoesSearch = '';
        vm.search = search;
        vm.filteredTransaccoes = [];
        vm.pageChanged = pageChanged;
        vm.transaccoesFilter = transaccoesFilter;

        vm.isLoading = false;
        vm.busyMessage = 'Por favor aguarde...'
        vm.ulClass = 'list-inline';

        vm.toggleGrid = toggleGrid;
        vm.toggleList = toggleList;

        vm.spinnerOptions = {
            radius: 40,
            lines: 7,
            length: 0,
            width: 30,
            speed: 1.7,
            corners: 1.0,
            trail: 100,
            color: '#F58A00'
        };
        
       
        vm.criterios = {
            wildCard: '',
            dataInicio: setDates(-15),
            dataFim: setDates(0)
        }




        vm.paging = {
            currentPage: 1,
            maxPagesToShow: 5,
            pageSize: 15
        }


        function toggleGrid() {

            vm.ulClass = 'list-inline';
        }

        function toggleList() {
            vm.ulClass = 'list-unstyled';
        }

        function setDates(offset) {

            var time = new Date();
            time.setDate(time.getDate() + offset);
            return time;
        }


        Object.defineProperty(vm.paging, 'pageCount', {
            get: function () {
               return Math.floor(vm.transaccoesFilteredCount / vm.paging.pageSize) + 1;
            }
        });

        activate();


        function applyFilter() { }

        function activate() {

            common.activateController([getTransaccoes()], controllerId)
                   .then(function () {
                       applyFilter = common.createSearchThrottle(vm, 'transaccoes');
                       if (vm.transaccoesSearch) { applyFilter(true) }
                       log('Activated Transaccoes View');
                   });
        }

        function getTransaccoesCount() {

            return datacontext.getTransaccoesCount().then(function (data) {
                return vm.transaccoesCount = data;
            });
        }

        function getTransaccoesFilteredCount() {
            vm.transaccoesFilteredCount = datacontext.getFilteredCount(vm.transaccoesSearch);
        }

        function getTransaccoes(forceRemote) {
            vm.isLoading = true;

            return datacontext.getTransaccoes(forceRemote, vm.paging.currentPage, vm.paging.pageSize, vm.transaccoesSearch)
                .then(function (data) {
                   
                    vm.transaccoes = data;
                    getTransaccoesFilteredCount();
                    if (!vm.transaccoesCount || forceRemote) {
                        getTransaccoesCount();
                    }

                    vm.isLoading = false;
                    return data;
                });
        }
        //#region Internal Methods        

        function refresh() {
            datacontext.setCriterioPesquisa(vm.criterios);
            getTransaccoes(true,vm.paging.currentPage,vm.paging.pageSize,vm.transaccoesSearch);
        }


        function search($event) {
            if ($event.keyCode === keyCodes.esc) {
                vm.transaccoesSearch = '';
                //applyFilter(true);
            }
            getTransaccoes(/*false, vm.paging.currentPage, vm.paging.pageSize, vm.transaccoesSearch, vm.clienteid*/);
           // else { applyFilter(); }

        }

        function pageChanged(page) {
            if (!page) { return; }
            vm.paging.currentPage = page;
            getTransaccoes(/*false,vm.paging.currentPage,vm.paging.pageSize,vm.transaccoesSearch,vm.clienteid*/);
        }



        function transaccoesFilter(transaccao) {

            var textContains = common.textContains;
            var searchText = vm.transaccoesSearch;
            var isMatch = searchText ?
                           textContains(transaccao.ctGuiaID, searchText)
                           || textContains(transaccao.conta.cDesgn_Com, searchText)
                           || textContains(transaccao.dataTransaccao, searchText)
                           || textContains(transaccao.tipoTransaccao, searchText)
                           : true;

            return isMatch;

        }
        //#endregion
    }
})();
