eventsApp.factory('eventData', function ($http, $log) {
    return {
        getEvent: function (id) {
            //$http: ({ method: 'GET', url: '/data/event/1' }).
            //    success(function (data, status, headers, config) {
            //        successcb(data);
            //    }).
            //    error(function (date, status, headers, config) {
            //        $log.warn(data, status, headers(), config);
            //    });

            return $http.get('http://localhost:63105/event/' + id + '?d=' + Date.now());
        }
    };
});