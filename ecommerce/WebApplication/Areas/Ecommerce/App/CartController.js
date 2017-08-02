angular.module("ecommerce").controller("CartController", function($scope, $http) {
    $scope.cart = {};

    var getCart = function() {
        $http.get("GetCart").then(function (response) {
            $scope.cart = response.data;
        });
    }

    $scope.removeProduct = function(product) {
        $http.post("RemoveProduct/" + product.Id).then(function(response) {
            $scope.cart = response.data;
        });
    }

    $scope.saveCount = function(product) {
        $http.post("ChangeCount/" + product.Id, { newCount: product.Count }).then(function(response) {
            $scope.cart = response.data;
        });
    }

    getCart();
})