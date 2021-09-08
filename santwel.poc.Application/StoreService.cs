using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santwel.poc
{
    public class StoreService : IStoreService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Product> _productRepository;

        public StoreService(IRepository<Order> orderRepository, IRepository<Product> productRepository)
        {
            this._orderRepository = orderRepository;
            this._productRepository = productRepository;
        }

        public IList<GetProductsOutPut> GetProducts()
        {

            var products = this._productRepository.GetAll().Select(p => new GetProductsOutPut
            {
                Name = p.Name,
                Description = p.Description,
                QtyReserverdForSale = p.QtyReserverdForSale,
                QtyAvailable = p.QtyAvailable,
                UnitPrice = p.UnitPrice,
                Id = p.Id
            }).ToList();
            return products;
        }

        public bool isProductAvailable(int productId, int quantity)
        {
            throw new NotImplementedException();
        }


        public void PlaceOrder(IList<PlaceOrderInput> orderInput)
        {
            

            var newOrder = new Order { CreatedOn= DateTime.Now};

            foreach (var item in orderInput)
            {

                var product = this._productRepository.Get(item.ItemId);
                product.QtyReserverdForSale = product.QtyReserverdForSale - item.QuantityOrdered;
                product.QtyAvailable = product.QtyAvailable - product.QtyReserverdForSale;

                this._productRepository.Update(product);

                var newItem = new Item
                {
                    Order = newOrder,
                    ItemId = item.ItemId,
                    QuantityOrdered = item.QuantityOrdered,
                    UnitPrice = item.UnitPrice,
                    Name = product.Name
                    
                };

                newOrder.AddItem(newItem);
            }

            var newOrderId = this._orderRepository.InsertOrUpdateAndGetId(newOrder);

        }


    }
}
