angular.module("ecommerce").controller("ProductController", function ($scope, $http, $rootScope) {
    $scope.addToCart = function (product) {
        $http.post("/ecommerce/ShoppingCart/AddProduct/" + product.Id,
            { name: product.Name, price: product.OfferPrice || product.Price, count: product.Quantity, url: product.MainUrl }).then(function(response) {
            $rootScope.$broadcast("cart-update", response.data);
        });
    }
})