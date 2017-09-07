var routingApp = angular.module('routing', ['ngRoute']);
routingApp.config(function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: 'login.html',
        controller: 'loginController'
    }).when('/user', {
        templateUrl: 'users.html',
        controller: 'userController'
    }).otherwise({
        redirectTo: '/'
    });
});
