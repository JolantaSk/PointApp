PointApp.factory('ListService', ['$http', function ($http) {

    var ListService = {};

    ListService.GetExistingLists = function () {
        return $http({
            url: '/api/List/GetAll',
            method: 'GET'
        });
    }

    ListService.GetList = function (listID) {
        return $http({
            url: '/api/List',
            method: 'GET',
            params: {listId: listID}
        });
    }
    return ListService;

}]);