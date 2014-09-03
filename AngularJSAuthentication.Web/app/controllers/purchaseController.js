'use strict';
app.controller('purchaseController', ['$scope', 'purchaseService', function ($scope, purchaseService) {

    $scope.purchases = [];

    purchaseService.getPurchase().then(function (results) {

        $scope.purchases = results.data;

    }, function (error) {
        //alert(error.data.message);
    });

}]);