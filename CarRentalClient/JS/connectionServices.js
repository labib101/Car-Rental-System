var con = angular.module('connectionServices', []);

con.service('getDataService', function ($http) {
    this.getConnected = function (apiPath) {
        $http.get("http://localhost/carrentalsystem/api/" + apiPath).then(function (promise) {
            return promise.data;
        });
    };

});

con.service('logInToServer', function ($http,$location) {
    this.getConnected = function (email, password) {
        var user = { ID: 1, Email: email, Password: password };
        return $http({ method: "post", url: "http://localhost/carrentalsystem/api/default", data: user });
        //$http({ method: "post", url: "http://localhost/carrentalsystem/api/default", data: user }).then(function (promise) {
        //    console.log(promise.data + " service reached");
        //    var entity = promise.data;
        //    return entity;
            
        //    return promise.data;
        //});
    };

});
con.service('getAdminDashInfo', function ($http, $location) {
    this.getCarDetails = function () {
        return $http({ method: "get", url: "http://localhost/carrentalsystem/api/cardetails"});
    };
    this.getUserDetails = function () {
        return $http({ method: "get", url: "http://localhost/carrentalsystem/api/UserDetails" });
    }
    this.getBankDetails = function () {
        return $http({ method: "get", url: "http://localhost/carrentalsystem/api/banks" });
    }
    this.getBookingDetails = function () {
        return $http({ method: "get", url: "http://localhost/carrentalsystem/api/bookingdetails" });
    }
    this.test = function () {
        return $http({ method: "get", url: "http://localhost/BangladeshTimes/api/index/getAllRestaurants" });
    }

});