PointApp.factory('ListService', ['$http', function ($http) {

    var ListService = {};

    ListService.GetExistingLists = function () {
        return $http({
            url: '/api/List/GetAll',
            method: 'GET'
        });
    }
    return ListService;

}]);