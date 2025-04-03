using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class WarehouseService
    {
        public async Task<List<ProductModel>> LoadProductsAsync()
        {
            await Task.Delay(2000); 
            return new List<ProductModel>
        {
            new ProductModel { Id = 1, Name = "Товар 1", Quantity = 10 },
            new ProductModel { Id = 2, Name = "Товар 2", Quantity = 5 }
        };
        }
    }
}
