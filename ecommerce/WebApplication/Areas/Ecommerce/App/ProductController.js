﻿angular.module("ecommerce").controller("ProductController", function ($scope, $http, $rootScope) {
    $scope.addToCart = function (product) {
        $http.post("ShoppingCart/AddProduct/" + product.Id,
            { name: product.Name, price: product.OfferPrice || product.Price, count: 1, url: product.Url }).then(function(response) {
            $rootScope.$broadcast("cart-update", response.data);
        });
    }
})