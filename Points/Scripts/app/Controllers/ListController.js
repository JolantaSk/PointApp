"use strict";

PointApp.controller('ListController', ['$scope', 'ListService', 'PointService', function ($scope, ListService, PointService) {

    $scope.IsListSelected = function () {
        return $scope.SelectedList != null;
    }

    $scope.LoadLists = function () {
        ListService.GetExistingLists()
        .then(function (response) {
            $scope.ExistingLists = response.data;
        });
    }

    $scope.LoadLists();

    $scope.LoadList = function (listId) {
        $scope.currentListID = listId;
        console.log(this.id);
        return ListService.GetList(listId)
        .then(function (response) {
            $scope.SelectedList = response.data;
        });
    }

    $scope.AddPoint = function (x, y) {
        return PointService.AddPoint(x, y, $scope.currentListID)
        .then(function () {
            $scope.SelectedList.push({coordinateX: x, coordinateY: y});
        });
    }

    $scope.RemovePoint = function(pointId) {
        return PointService.RemovePoint(pointId, $scope.currentListID)
        .then(function() {
            $scope.LoadList($scope.currentListID);
        });
    }

    $scope.RemoveList = function () {
        return ListService.RemoveList($scope.currentListID)
        .then(function () {
            $scope.LoadLists();
        });
    }
}]);