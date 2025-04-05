using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using Task1.Models;
using Task1.Services;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ProductService _productService;
        private readonly Storyboard _rotateRefreshButton;
        private readonly Storyboard _showDetailsPanel;

        public MainWindow()
        {
            InitializeComponent();
            
            _productService = new ProductService();
            _rotateRefreshButton = (Storyboard)FindResource("RotateRefreshButton");
            _showDetailsPanel = (Storyboard)FindResource("ShowDetailsPanel");

            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductsGrid.ItemsSource = _productService.GetAllProducts();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            
            _rotateRefreshButton.Begin(RefreshButton);
            _productService.SimulateStockUpdate();
            LoadProducts();
        }

        private void ProductsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductsGrid.SelectedItem is Product selectedProduct)
            {
                NameText.Text = selectedProduct.Name;
                CategoryText.Text = selectedProduct.Category;
                QuantityText.Text = selectedProduct.Quantity.ToString();
                PriceText.Text = selectedProduct.Price.ToString("C");
                MinStockText.Text = selectedProduct.MinimumStock.ToString();
                _showDetailsPanel.Begin(DetailsPanel);
            }
        }
    }
}