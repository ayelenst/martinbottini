angular.module("ecommerce").controller("CartPreviewController", function($scope, $http) {
    $scope.cart = {};

    var getCart = function() {
        $http.get("ShoppingCart/GetCart").then(function (response) {
            $scope.cart = response.data;
        });
    }

    $scope.$on("cart-update",
        function(e, data) {
            $scope.cart = data;
        });

    getCart();
})