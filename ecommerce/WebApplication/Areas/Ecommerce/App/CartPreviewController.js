angular.module("ecommerce").controller("CartPreviewController", function($scope, $http) {
    $scope.cart = {};

    var getCart = function() {
        $http.get("ShoppingCart/GetCart").then(function (response) {
            $scope.cart = response.data;
        });
    }

    getCart();
})