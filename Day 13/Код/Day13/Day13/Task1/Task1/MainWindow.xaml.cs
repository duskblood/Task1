using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            
            Products = new ObservableCollection<Product>();
            ProductsDataGrid.ItemsSource = Products;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
      
            var product = new Product { Name = "Новый товар", Quantity = 1, Price = 0.0 };
            Products.Add(product);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (ProductsDataGrid.SelectedItem is Product selectedProduct)
            {
                selectedProduct.Name = "Редактированный товар"; 

            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
         
            if (ProductsDataGrid.SelectedItem is Product selectedProduct)
            {
                Products.Remove(selectedProduct);
            }
        }
    }
}