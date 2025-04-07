using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp1.Models;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace WpfApp1.ViewModels
{
    public class WarehouseViewModel : BaseViewModel, IDisposable
    {
        private readonly WarehouseDbContext _context;
        private readonly ProductRepository _repository;
        private Product _selectedProduct;
        private readonly SemaphoreSlim _dbLock = new SemaphoreSlim(1, 1);

        public ObservableCollection<Product> Products { get; } = new ObservableCollection<Product>();
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddProductCommand { get; }
        public ICommand UpdateProductCommand { get; }
        public ICommand DeleteProductCommand { get; }
        public ICommand LoadProductsCommand { get; }

        public WarehouseViewModel()
        {
            _context = new WarehouseDbContext();
            _repository = new ProductRepository(_context);

            AddProductCommand = new RelayCommand(async () => await AddProduct());
            UpdateProductCommand = new RelayCommand(async () => await UpdateProduct());
            DeleteProductCommand = new RelayCommand(async () => await DeleteProduct());
            LoadProductsCommand = new RelayCommand(async () => await LoadProducts());

            LoadProductsCommand.Execute(null);
        }

        private async Task AddProduct()
        {
            try
            {
                await _dbLock.WaitAsync();
                var newProduct = new Product
                {
                    Name = "Новый товар",
                    Description = "Описание",
                    Price = 0,
                    Quantity = 0
                };

                await _repository.AddAsync(newProduct);
                await _context.SaveChangesAsync();
                
                // Добавляем новый товар в коллекцию
                Products.Add(newProduct);
                SelectedProduct = newProduct;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении товара: {ex.Message}\n\nПодробности: {ex.InnerException?.Message}", 
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _dbLock.Release();
            }
        }

        private async Task UpdateProduct()
        {
            if (SelectedProduct == null) return;

            try
            {
                await _dbLock.WaitAsync();
                var productToUpdate = SelectedProduct;
                
                await _repository.UpdateAsync(productToUpdate);
                await _context.SaveChangesAsync();
                
                // Обновляем товар в коллекции
                var index = Products.IndexOf(productToUpdate);
                if (index != -1)
                {
                    Products[index] = productToUpdate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении товара: {ex.Message}\n\nПодробности: {ex.InnerException?.Message}", 
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _dbLock.Release();
            }
        }

        private async Task DeleteProduct()
        {
            if (SelectedProduct == null) return;

            try
            {
                await _dbLock.WaitAsync();
                var productToDelete = SelectedProduct;
                
                await _repository.DeleteAsync(productToDelete);
                await _context.SaveChangesAsync();
                
                // Удаляем товар из коллекции
                Products.Remove(productToDelete);
                SelectedProduct = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении товара: {ex.Message}\n\nПодробности: {ex.InnerException?.Message}", 
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _dbLock.Release();
            }
        }

        private async Task LoadProducts()
        {
            try
            {
                await _dbLock.WaitAsync();
                var products = await _repository.GetAllAsync();
                Products.Clear();
                foreach (var product in products)
                {
                    Products.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке товаров: {ex.Message}\n\nПодробности: {ex.InnerException?.Message}", 
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _dbLock.Release();
            }
        }

        public void Dispose()
        {
            _dbLock?.Dispose();
            _context?.Dispose();
        }
    }
} 