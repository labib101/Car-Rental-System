var app = angular.module('configuration', []).config(['$locationProvider', function ($locationProvider) {
    $locationProvider.hashPrefix('');
}]);