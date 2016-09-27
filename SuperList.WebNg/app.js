(function () {
    var app = angular.module('superlist', ['ngRoute']);

    var config = function ($routeProvider) {
        var buildUrl = function(view) {
            return 'views/' + view + '.html'; 
        }; 

        $routeProvider
            .when('/', {
                templateUrl: buildUrl('home'),
                controller: 'homeCtrl'
            })

            //.when('/login', {
            //    templateUrl: buildUrl('login'),
            //    controller: 'loginCtrl'
            //})

            //.when('/registrar', {
            //    templateUrl: buildUrl('registrar'),
            //    controller: 'registrarCtrl'
            //})

            .when('/listaDeCompra/criar', {
                templateUrl: buildUrl('listaDeCompraCriar'),
                controller: 'listaDeCompraCriarCtrl'
            })

            .when('/listaDeCompra/:id/secao/:secaoId', {
                templateUrl: buildUrl('listaDeCompraSecao'),
                controller: 'listaDeCompraSecaoCtrl'
            })

            //.when('/listaDeCompra/minhasListas', {
            //    templateUrl: buildUrl('listaDeCompraListar'),
            //    controller: 'listaDeCompraListarCtrl'
            //})

            //.when('/servicos/:id', {
            //    templateUrl: buildUrl('servicosDetail'),
            //    controller: 'servicosDetailCtrl'
            //})

            .otherwise({ redirectTo: '/' });
    }

    app.config(config);

    //app.config(['$routeProvider'], function ($routeProvider) {
    //    //$locationProvider.html5Mode(true);
    //    $routeProvider
    //        .when('/', {
    //            templateUrl: 'appone/views/home.html',
    //            controller: 'homeCtrl'
    //        })
    //        .otherwise({ redirectTo: '/' });
    //})
}());