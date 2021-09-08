using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santwel.poc
{
    public interface IStoreService: IApplicationService
    {

        IList<GetProductsOutPut> GetProducts();
        bool isProductAvailable(int productId, int quantity);

        void PlaceOrder(IList<PlaceOrderInput> orderInput);

    }
}
