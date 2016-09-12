PointApp.factory('ListService', ['$http', function ($http) {

    var ListService = {};

    ListService.getCurrency = function () {
        return $http({
            url: '/api/List/GetAll',
            method: 'GET'
        });
    }
    return ListService;

}]);