(function () {
    'use strict';

    var app = angular.module('app');

    // Collect the routes
    app.constant('routes', getRoutes());

    // Configure the routes and route resolvers
    app.config(['$routeProvider', 'routes', routeConfigurator]);
    function routeConfigurator($routeProvider, routes) {

        routes.forEach(function (r) {
            $routeProvider.when(r.url, r.config);
            //setRoute(r.url, r.config);
        });
        $routeProvider.otherwise({ redirectTo: '/' });

        //function setRoute(url, definition) {
        //    definition.resolve = angular.extend(definition.resolve || {}, {
        //        prime: prime
        //    });
        //    $routeProvider.when(url, definition);

        //    return $routeProvider;
        //}
    }



    prime.$inject = ['datacontext'];
    function prime(datacontext) { return datacontext.prime(); }




    // Define the routes 
    function getRoutes() {
        return [
            {
                url: '/',
                config: {
                    templateUrl: 'app/dashboard/dashboard.html',
                    title: 'dashboard',
                    settings: {
                        nav: 1,
                        content: '<i class="icon-dashboard"></i> Dashboard'
                    }
                }
            }
            , {
                url: '/transaccoes',
                config: {
                    title: 'transaccoes',
                    templateUrl: 'app/transaccao/transaccoes.html',
                    settings: {
                        nav: 5,
                        content: '<i class="icon-truck"></i> Transacções'
                    }
                }
            }
        ];
    }
})();