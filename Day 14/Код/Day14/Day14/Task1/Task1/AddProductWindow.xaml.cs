using System.Windows;

namespace Task1
{
    public partial class AddProductWindow : Window
    {
        public string ProductName { get; private set; }
        public int ProductQuantity { get; private set; }

        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ProductName = ProductNameTextBox.Text;
            if (int.TryParse(ProductQuantityTextBox.Text, out int quantity))
            {
                ProductQuantity = quantity;
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Введите корректное количество.");
            }
        }
    }
}