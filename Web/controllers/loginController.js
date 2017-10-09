﻿'use strict';
app.controller('loginController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.loginData = {
        userName: "felipe",
        password: "felipe01"
    };

    $scope.message = "";

    $scope.login = function () {

        authService.login($scope.loginData).then(function (response) {
            $location.path('/contatos');
        },
         function (err) {
             $scope.message = "Ocorreu algum erro ao autenticar.";
         });
    };

}]);