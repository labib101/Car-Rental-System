angular.module('services', []).service('loginService', ['$http', '$location', '$scope', function ($http, $location, $scope) {
    function login(username, password) {

        var auth = { ID: 1, Email: username, Password: password };
        $http({ method: "post", url: "http://localhost/carrentalsystem/api/default", data: user }).then(function (promise) {
            if (promise.data == "success") {

                return "success";
            }
            else {
                return "Error";
            }

        });

    }
}])