angular.module('shipments.home', [])
    .controller('HomeCtrl', function ($scope, auth, $location) {
        $scope.shipments = [];
        $scope.auth = auth;

        $scope.logout = function () {
            auth.signout();
            $location.path('/login');
        }
    });