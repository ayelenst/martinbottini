angular.module("ecommerce").controller("CartController", function($scope, $http) {
    $scope.cart = {};

    var getCart = function() {
        $http.get("/ecommece/ShoppingCart/GetCart").then(function (response) {
            $scope.cart = response.data;
        });
    }

    $scope.removeProduct = function(product) {
        $http.post("/ecommerce/ShoppingCart/RemoveProduct/" + product.Id).then(function(response) {
            $scope.cart = response.data;
        });
    }

    $scope.saveCount = function(product) {
        $http.post("/ecommerce/ShoppingCart/ChangeCount/" + product.Id, { newCount: product.Count }).then(function(response) {
            $scope.cart = response.data;
        });
    }

    getCart();
})