using System.Windows;

namespace Task1
{
    public partial class EditProductWindow : Window
    {
        public string ProductName { get; private set; }
        public int ProductQuantity { get; private set; }
        public decimal ProductPrice { get; private set; }
        public string ProductCategory { get; private set; }

        public EditProductWindow(string name, int quantity, decimal price, string category)
        {
            InitializeComponent();
            ProductNameTextBox.Text = name;
            ProductQuantityTextBox.Text = quantity.ToString();
            ProductPriceTextBox.Text = price.ToString("0.00");
            ProductCategoryTextBox.Text = category;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ProductName = ProductNameTextBox.Text;

            if (int.TryParse(ProductQuantityTextBox.Text, out int quantity) &&
                decimal.TryParse(ProductPriceTextBox.Text, out decimal price))
            {
                ProductQuantity = quantity;
                ProductPrice = price;
                ProductCategory = ProductCategoryTextBox.Text;

                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Введите корректные данные.");
            }
        }
    }
}