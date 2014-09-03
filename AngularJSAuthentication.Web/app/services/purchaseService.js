'use strict';
app.factory('purchaseService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var purchaseServiceFactory = {};

    var _getPurchase = function () {

        return $http.get(serviceBase + 'api/purchase').then(function (results) {
            return results;
        });
    };

    ordersServiceFactory.getPurchase = _getPurchase;

    return purchaseServiceFactory;

}]);