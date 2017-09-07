var cont = angular.module('controllers', ['connectionServices']);
cont.controller('login', ['$scope', '$location','logInToServer', function ($scope, $location,logInToServer) {
    $scope.connect = function (data) {
        $scope.q = true;
        logInToServer.getConnected($scope.email, $scope.password).then(function (result) {
            if (result.data == "Admin") {

                $location.path('/dashAd');
                console.log("Login Successfull");
                $scope.q = false;
            }
            else if (result.data == "Customer") {
                $location.path('/dashCus');
                console.log("Login Successfull");
                $scope.q = false;
            }
            else {
                $location.path('/!231lmoc0');
                console.log("Error Logging in" + result.data);
                $scope.q = false;
            }
        });
    }
}])
cont.controller('adminDashController', ['$scope', '$location', 'getAdminDashInfo', function ($scope, $location, getAdminDashInfo) {
    $scope.q = true;
    getAdminDashInfo.getCarDetails().then(function (promise) {
        $scope.CarDetails = promise.data;
        $scope.noofCars = promise.data.length;

        getAdminDashInfo.getUserDetails().then(function (promise) {
            $scope.Users = promise.data;
            $scope.noofUsers = promise.data.length;

            getAdminDashInfo.getBankDetails().then(function (promise) {
                $scope.Banks = promise.data;
                $scope.noofBanks = promise.data.length;

                getAdminDashInfo.getBookingDetails().then(function (promise) {
                    $scope.Bookings = promise.data;
                    $scope.noofBookings = promise.data.length;
                    $scope.q = false;

                    getAdminDashInfo.test().then(function (promise) {
                        $scope.st = promise.data;
                        console.log("reached " + promise.data);
                    })
                })
                //$scope.q = false;
            })
            //$scope.q = false;
        })
        //$scope.q = false;
    })

    $scope.add = function () {
        $location.path('/addcar');
    }
    

}]);

