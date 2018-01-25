'use strict';

eventsApp.controller('EventController',
    function EventController($scope, eventData) {
        var init;

        $scope.snippet = '<span style="color:red">hi there</span>';
        $scope.boolValue = true;
        $scope.mystyle = { color: 'red' };
        $scope.myclass = "blue";
        $scope.buttonDisabled = true;
        $scope.sortOrder = 'name';
        //eventData.getEvent(function (event) {
        //    $scope.event = event;
        //});

        init = function () {
            eventData.getEvent(1)
                .then(function (result) {
                    if (result.status === 200 && result.data) {
                        $scope.event = result.data;
                    }
                });
        };

        $scope.upVoteSession = function (session) {
            session.upVoteCount++;
        };

        $scope.downVoteSession = function (session) {
            session.upVoteCount--;
        };

        init();
    }
);