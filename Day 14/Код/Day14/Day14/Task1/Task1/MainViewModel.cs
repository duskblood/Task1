using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Task1
{
    public class MainViewModel
    {

        public ObservableCollection<Product> Products { get; }
        public ICommand AddProductCommand { get; }
        public ICommand EditProductCommand { get; }
        public ICommand DeleteProductCommand { get; }
        public ICommand ExitCommand { get; }

        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
                // Обновляем состояние команд
                ((RelayCommand)EditProductCommand).RaiseCanExecuteChanged();
                ((RelayCommand)DeleteProductCommand).RaiseCanExecuteChanged();
            }
        }

        public MainViewModel()
        {
            Products = new ObservableCollection<Product>();
            AddProductCommand = new RelayCommand(AddProduct);
            EditProductCommand = new RelayCommand(EditProduct, CanEditOrDelete);
            DeleteProductCommand = new RelayCommand(DeleteProduct, CanEditOrDelete);
            ExitCommand = new RelayCommand(ExitApplication);
        }

        private bool CanEditOrDelete(object parameter) => SelectedProduct != null;

        private void AddProduct(object parameter)
        {
            var addProductWindow = new AddProductWindow();
            if (addProductWindow.ShowDialog() == true)
            {
                Products.Add(new Product { Name = addProductWindow.ProductName, Quantity = addProductWindow.ProductQuantity });
            }
        }

        private void EditProduct(object parameter)
        {
            if (SelectedProduct == null) return;

            var editProductWindow = new EditProductWindow(SelectedProduct.Name, SelectedProduct.Quantity);
            if (editProductWindow.ShowDialog() == true)
            {
                SelectedProduct.Name = editProductWindow.ProductName;
                SelectedProduct.Quantity = editProductWindow.ProductQuantity;
            }
        }

        private void DeleteProduct(object parameter)
        {
            if (SelectedProduct == null) return;

            if (MessageBox.Show("Вы уверены, что хотите удалить товар?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Products.Remove(SelectedProduct);
            }
        }

        private void ExitApplication(object parameter) => Application.Current.Shutdown();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

      

    
}
