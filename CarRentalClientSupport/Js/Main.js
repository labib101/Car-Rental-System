
var app = angular.module('CarRentalMain', ['routing', 'configuration', 'controllers', 'services']).run(['$rootscope', function ($rootscope) {
        $rootscope.topbar = false;
        $rootscope.loader = true;

       
    }]);
   

