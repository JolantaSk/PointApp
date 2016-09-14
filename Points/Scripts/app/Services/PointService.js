PointApp.factory('PointService', ['$http', function ($http) {

    var PointService = {};

    PointService.AddPoint = function (x, y, listId) {
        return $http({
            url: '/api/Point/AddPoint',
            method: 'POST',
            params: {coordinateX: x, coordinateY: y, listID: listId}
        });
    }

    PointService.RemovePoint = function (pointId, listId) {
        return $http({
            url: '/api/Point/RemovePoint',
            method: 'POST',
            params: { pointID: pointId, listID: listId }
        });
    }
    return PointService;

}]);