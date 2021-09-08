(function() {
    var controllerId = 'app.views.home';
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.app.storeService', function ($scope, storeService) {
            var vm = this;
            //Home logic...


            vm.order = [];
            vm.products = [];// [p1, p2, p3];


            storeService.getProducts().then(function (result) {
                vm.products = result.data;//.products;
            });


            vm.getProducts = function () {

                storeService.getProducts().then(function (result) {
                    vm.products = result.data;//.products;
                });
            }
            vm.finishOrder = function () {



                storeService.placeOrder(vm.order)
                    .then(function (result) {
                        vm.getProducts();
                });

            }


            vm.placeOrder = function (product, qtyOrdered) {

                if (isProductAvailableToSale(product.id, qtyOrdered)) {
                    var newOrderDetail = { itemId: product.id, unitPrice: product.unitPrice, quantityOrdered: qtyOrdered };

                    vm.order.push(newOrderDetail);
                   
                    vm.finishOrder();
                    //TODO:Refresh Products view.
                }
                console.log('place order...');
            }

           

            function isProductAvailableToSale(productId, orderQuantity) {

                return true;

            }



        }
    ]);
})();

/*
 Backend:
• Lists of merchandise available for sale. UI-OK, BE-?
• Max Qty the store can stock, Available Qty, Qty reserved for sale, Unit price of the merchandise, Qty
returned by customer & location of the merchandise at the store
User Interface with CRUD options:
• View to display all the available merchandise and associated data e.g., available qty, unit price etc. for the customers to place an order.
• Allow users to take Orders from a customers based on the available Qty.
• Allow customers to return the merchandise.
• Create a printable invoice for the order placed by the customer.
 
 */