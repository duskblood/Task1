using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class WarehouseModel
    {
        public ObservableCollection<ProductModel> Products { get; set; } = new ObservableCollection<ProductModel>();
    }
}
