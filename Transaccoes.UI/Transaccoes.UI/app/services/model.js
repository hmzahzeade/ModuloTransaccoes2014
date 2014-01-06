(function () {
    'use strict';

    // Factory name is handy for logging
    var serviceId = 'model';

    // Define the factory on the module.
    // Inject the dependencies. 
    // Point to the factory definition function.
    // TODO: replace app with your module name
    angular.module('app').factory(serviceId, model);

    function model() {
        // Define the functions and properties to reveal.
        var service = {
            configureMetadataStore: configureMetadataStore
        };

        return service;


        function configureMetadataStore(metadataStore) {
            _registerCabecalhoTransaccao(metadataStore);
            _addCabTransaccoesBrief(metadataStore);
            _registerCabecalhoTransaccaoBrief(metadataStore);
        }

        //#region Internal Methods    

        function _addCabTransaccoesBrief(metadataStore) {

            var et = new breeze.EntityType({
                shortName: 'CabecalhoTransaccoesBrief',
                namespace: 'PDT.Data.Models',
                defaultResourceName: 'CabecalhoTransaccoesBrief',

                dataProperties: {
                    ctGuiaID: { dataType: breeze.DataType.String, isPartOfKey: true },
                    dCom: { dataType: breeze.DataType.String },
                    ctDataFim: { dataType: breeze.DataType.DateTime },
                    ctClienteID: { dataType: breeze.DataType.String },
                    ctTipoTran: { dataType: breeze.DataType.String },
                    ctOrigem: { dataType: breeze.DataType.String },
                    servicos: {complexTypeName: "Servico:#PDT.Data.Models", isScalar: false},
                    produtos: {complexTypeName: "Prd:#PDT.Data.Models", isScalar: false}

                }

            });

            metadataStore.addEntityType({
                shortName: 'Servico',
                namespace: 'PDT.Data.Models',
                isComplexType: true,
                dataProperties: {
                    servico: {dataType: breeze.DataType.String}
                }
            });

            metadataStore.addEntityType({
                shortName: 'Prd',
                namespace: 'PDT.Data.Models',
                isComplexType: true,
                dataProperties: {
                    servico: { dataType: breeze.DataType.String }
                }
            });
            
            metadataStore.addEntityType(et);
        }

        function _registerCabecalhoTransaccao(metadataStore) {
            metadataStore.registerEntityTypeCtor('CabecalhoTransacco', CabecalhoTransacco);

            function CabecalhoTransacco() { }

            Object.defineProperty(CabecalhoTransacco.prototype, 'tipoTransaccao', {
                get: function () {

                    //var detalhes = this.detalheTransaccoes;
                    //var countEnt = 0;
                    //var countRec = 0;

                    //detalhes.forEach(function (det) {
                    //    if (det.dtQtdEnt > 0) countEnt++;
                    //    if (det.dtQtdRec > 0) countRec++;
                    //});

                    var tipoTransaccao;

                    //if (countRec > 0 && countEnt === 0) tipoTransaccao = 'So Entrega'; //'fa fa-2x fa-long-arrow-right';
                    //if (countRec === 0 && countEnt > 0) tipoTransaccao = 'So Recolha';//'fa fa-2x fa-long-arrow-left';
                    //if (countRec > 0 && countEnt > 0) tipoTransaccao = 'Entrega e Recolha'; //'fa fa-2x fa-arrows-h';
                    //if (detalhes.length === 0) tipoTransaccao = 'Sem Detalhe';//

                    if (this.ctTipoTran === '2') tipoTransaccao = 'So Entrega'; //'fa fa-2x fa-long-arrow-right';
                    if (this.ctTipoTran ==='1') tipoTransaccao = 'So Recolha';//'fa fa-2x fa-long-arrow-left';
                    if (this.ctTipoTran === '3') tipoTransaccao = 'Entrega e Recolha'; //'fa fa-2x fa-arrows-h';
                    if (this.ctTipoTran === '0') tipoTransaccao = 'Sem Detalhe';//

                    return tipoTransaccao;
                }
            });

            Object.defineProperty(CabecalhoTransacco.prototype, 'origem', {
                get: function () {

                    var origem;
                    if (this.ctOrigem != null) {
                        if (this.ctOrigem.indexOf('Guia Manual') != -1)
                            origem = 0;//'fa fa-5x fa-file-o';
                        else
                            origem = 1;//'fa fa-5x fa-tablet';
                    }
                    else {
                        origem = 1;//'fa fa-5x fa-tablet'
                    }

                    return origem;
                }
            });

            Object.defineProperty(CabecalhoTransacco.prototype, 'dataTransaccao', {
                get: function () {

                  
                    return moment(this.ctDataFim).format('DD-MM-YYYY HH:MM');
                }
            });
        }

        function _registerCabecalhoTransaccaoBrief(metadataStore) {
            metadataStore.registerEntityTypeCtor('CabecalhoTransaccoesBrief', CabecalhoTransaccoesBrief);

            function CabecalhoTransaccoesBrief() { }

            Object.defineProperty(CabecalhoTransaccoesBrief.prototype, 'tipoTransaccao', {
                get: function () {

                    var tipoTransaccao;

                    if (this.ctTipoTran === '2') tipoTransaccao = 'So Entrega'; //'fa fa-2x fa-long-arrow-right';
                    if (this.ctTipoTran === '1') tipoTransaccao = 'So Recolha';//'fa fa-2x fa-long-arrow-left';
                    if (this.ctTipoTran === '3') tipoTransaccao = 'Entrega e Recolha'; //'fa fa-2x fa-arrows-h';
                    if (this.ctTipoTran === '0') tipoTransaccao = 'Sem Detalhe';//

                    return tipoTransaccao;
                }
            });

            Object.defineProperty(CabecalhoTransaccoesBrief.prototype, 'origem', {
                get: function () {

                    var origem;
                    if (this.ctOrigem != null) {
                        if (this.ctOrigem.indexOf('Guia Manual') != -1)
                            origem = 0;//'fa fa-5x fa-file-o';
                        else
                            origem = 1;//'fa fa-5x fa-tablet';
                    }
                    else {
                        origem = 1;//'fa fa-5x fa-tablet'
                    }

                    return origem;
                }
            });

            Object.defineProperty(CabecalhoTransaccoesBrief.prototype, 'dataTransaccao', {
                get: function () {


                    return moment(this.ctDataFim).format('DD-MM-YYYY HH:MM');
                }
            });
        }
        //#endregion
    }
})();