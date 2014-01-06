(function () {
    'use strict';

    // Factory name is handy for logging
    var serviceId = 'routemediator';

    // Define the factory on the module.
    // Inject the dependencies. 
    // Point to the factory definition function.
    // TODO: replace app with your module name
    angular.module('app').factory(serviceId, ['config','logger','$rootScope','$location', routemediator]);

    function routemediator(config,logger, $rootScope,$location) {
        // Define the functions and properties to reveal.
        var service = {
            setupRoutingHandlers: setupRoutingHandlers
        };

        return service;

        var handleRouteChangeError = false;

        function setupRoutingHandlers(){
            updateDocTitle();
            handleRoutingErrors();
        }

        function handleRoutingErrors() {
            $rootScope.$on('$routeChangeError', function (event, current, previous, rejection) {
                if (handleRouteChangeError) { return; }

                handleRouteChangeError = true;
                var msg = 'routing error: ' + (current && current.name) + '. ' + rejection.msg;
                logger.logWarning(msg, current, serviceId, true);
                $location.path('/');
            });
        }

        function updateDocTitle() {
            $rootScope.$on('$routeChangeSuccess', function (event, current, previous) {
                handleRouteChangeError = false;
                var title = config.docTitle + ' ' + (current.title || '');
                $rootScope.title = title;
            });
        }


    }

})();