var routing = angular.module('routingCustom', ['ngRoute']);
routing.config(function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: 'login.html',
        controller: 'login'
    }).when('/dashAd', {
        templateUrl: 'adminDashBoard.html',
        controller: 'adminDashController'
    }).when('/dashCus', {
        templateUrl: 'customerDashboard.html',
        controller: 'custDashController'
    }).when('/addcar', {
        templateUrl: 'addcar.html',
        controller: 'adminDashController'
    }).otherwise({ redirectTo: '/' });
});
routing.config(['$locationProvider', function ($locationProvider) {
    $locationProvider.hashPrefix('');
}]);