var app = angular.module('admin-single-app', ['ngRoute']);


app.config(function ($routeProvider) {


    $routeProvider
        .when('/', {
            templateUrl: 'home.html',
        })
        .when('/roles', {
            templateUrl: 'Roles',
        })
        .when('/user', {
            templateUrl: 'Users'
        });



});



