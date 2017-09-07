var control = angular.module('controllers', ['userController']);
control.controller('loginController', ['$scope', 'loginService', function ($scope, loginService) {
    $scope.submit = function () {
        $scope.q = true;
        var response = loginService.login($scope.email, $scope.password);
        if (response == "success") {

            $location.path('/item');
            console.log("Login Successfull");
            $scope.q = false;
        }
        else {
            $scope.q = false;
            console.log(response);
        }
    }
    
}])