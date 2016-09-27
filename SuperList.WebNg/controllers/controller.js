﻿(function (app) {
    var defaultUrl = "http://localhost:60323/api";

    app.controller('homeCtrl', function () {

    });

    app.controller('listaDeCompraCriarCtrl', function ($scope, $http) {
        $http({
            method: 'GET',
            url: defaultUrl + "/ListaDeCompra/ObterListaPadrao",
            params: {}
        })
        .then(function (result) {
            $scope.ListaPadrao = result.data;
        });
    });

    app.controller('listaDeCompraSecaoCtrl', function ($scope, $http) {
        $http({
            method: 'GET',
            url: defaultUrl + "/ListaDeCompra/"
        })
    })

    //app.controller('servicosDetailCtrl', function ($scope, $http, $routeParams, $location) {
    //    var id = $routeParams.id;
    //    if (id > 0) {
    //        $http.get("api/servicos/" + id)
    //            .success(function(data) {
    //                $scope.servico = data;
    //            })
    //    }

    //    $scope.save = function () {
    //        if ($scope.servico.Id == undefined) {
    //            $http.post("api/servicos/", $scope.servico)
    //                .then(function () {
    //                    alert('Serviço incluido com sucesso');
    //                    $location.path("/servicos");
    //                });
    //        } else {
    //            $http.put("api/servicos/", $scope.servico)
    //                .then(function () {
    //                    alert('Serviço alterado com sucesso');
    //                    $location.path("/servicos");
    //                });
    //        }
    //    }

    //    $scope.cancel = function () {
    //        $location.path("/servicos");
    //    }

        
    //})

    //app.controller('registrarCtrl', function ($scope, $http, $location) {
    //    $scope.registrar = function () {
    //        $http.post('api/Account/Register', $scope.usuario)
    //            .success(function () {
    //                alert('Usuário incluído com sucesso');
    //                $location.path('/');
    //            });
    //    }
    //})

    //app.controller('loginCtrl', function ($scope, $http) {
    //    $scope.login = function () {
    //        $scope.grant_type = 'password';
    //        $http.post('/Token', $scope.usuario)
    //            .success(function (data) {
    //                sessionStorage.setItem(tokenKey, data.access_token);
    //            })
    //            .error(function () {
    //                alert('Erro');
    //            })
    //    }
    //})
}(angular.module('superlist')));
