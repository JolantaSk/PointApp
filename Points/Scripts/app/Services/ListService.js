PointApp.factory('ListService', ['$http', function ($http) {

    var ListService = {};

    ListService.GetExistingLists = function () {
        return $http({
            url: '/api/List/GetAllLists',
            method: 'GET'
        });
    }

    ListService.GetList = function (listId) {
        return $http({
            url: '/api/List/GetList',
            method: 'GET',
            params: {listID: listId}
        });
    }

    ListService.RemoveList = function (listId) {
        return $http({
            url: '/api/List/RemoveList',
            method: 'POST',
            params: { listID: listId }
        });
    }
    return ListService;

}]);