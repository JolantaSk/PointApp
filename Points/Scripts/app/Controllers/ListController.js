"use strict";

PointApp.controller('ListController', ['$scope', 'ListService', function ($scope, ListService) {

    //this.ExistingLists = ListService.GetExistingLists();
    ListService.GetExistingLists()
    .then(function (response) {
        $scope.ExistingLists = response.data;
    });
    //$scope.GetExistingLists = function () {
    //    $scope.error = false;
    //    var requestedDate = $scope.selectedDate;

    //    if (requestedDate != undefined && requestedDate != '') {
    //        return CurrencyService.getCurrency(requestedDate)
    //        .then(function (response) {
    //            $scope.Currencies = response.data;
    //        }, function () {
    //            $scope.error = true;
    //            $scope.errorMsg = "Error during the operation. Please check the dates and try again.";
    //        });
    //    } else {
    //        $scope.error = true;
    //        $scope.errorMsg = "Please enter a valid date";
    //    }
    //}
}]);