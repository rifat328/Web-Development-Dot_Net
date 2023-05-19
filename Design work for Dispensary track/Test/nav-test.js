var app = angular.module('myApp', ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider
        .when('/home', {
            templateUrl: 'Home.html'
        })
        .when('/about', {
            templateUrl: 'About.html'
        })
        .when('/contact', {
            templateUrl: 'Login.html'
        })
        .otherwise({
            redirectTo: '/home'
        });
});

app.controller('NavController', function ($scope) {
    // Add any necessary controller logic here
});
