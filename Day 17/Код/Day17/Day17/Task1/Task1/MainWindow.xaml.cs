using System;
using System.Windows;
using System.Windows.Controls;
using Task1.Models;
using Task1.Services;
using System.Collections.Generic;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DataService _dataService;
        private readonly AuthService _authService;
        private readonly CommunicationService _communicationService;
        private User _currentUser;

        public MainWindow()
        {
            InitializeComponent();
            
            _dataService = new DataService();
            _authService = new AuthService(_dataService);
            _communicationService = new CommunicationService();

            _communicationService.NotificationReceived += OnNotificationReceived;
            _communicationService.ChatMessageReceived += OnChatMessageReceived;

            // Создаем начальные данные, если их нет
            InitializeDefaultData();
            LoadProducts();
        }

        private void InitializeDefaultData()
        {
            // Создаем администратора по умолчанию, если файл пользователей пуст
            var users = _dataService.LoadUsers();
            if (users.Count == 0)
            {
                users.Add(new User
                {
                    Id = 1,
                    Username = "admin",
                    PasswordHash = _authService.HashPassword("admin"),
                    FullName = "Администратор",
                    Role = "Admin",
                    LastLogin = DateTime.Now
                });
                _dataService.SaveUsers(users);
            }

            // Создаем тестовые товары, если файл товаров пуст
            var products = _dataService.LoadProducts();
            if (products.Count == 0)
            {
                products.AddRange(new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Товар 1",
                        Quantity = 10,
                        Price = 100.00m,
                        Description = "Описание товара 1",
                        LastUpdated = DateTime.Now
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Товар 2",
                        Quantity = 20,
                        Price = 200.00m,
                        Description = "Описание товара 2",
                        LastUpdated = DateTime.Now
                    }
                });
                _dataService.SaveProducts(products);
            }
        }

        private void LoadProducts()
        {
            var products = _dataService.LoadProducts();
            ProductsGrid.ItemsSource = products;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var username = UsernameTextBox.Text;
            var password = PasswordBox.Password;

            _currentUser = _authService.AuthenticateUser(username, password);

            if (_currentUser != null)
            {
                LoginGrid.Visibility = Visibility.Collapsed;
                MainGrid.Visibility = Visibility.Visible;
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ViewProducts_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 0;
            LoadProducts();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            var product = new Product
            {
                Id = new Random().Next(1000, 9999),
                Name = "Новый товар",
                Quantity = 0,
                Price = 0,
                LastUpdated = DateTime.Now
            };

            var products = _dataService.LoadProducts();
            products.Add(product);
            _dataService.SaveProducts(products);

            _communicationService.SendNotification($"Добавлен новый товар: {product.Name}");
            LoadProducts();
        }

        private void OpenChat_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MessageTextBox.Text))
                return;

            var message = $"{_currentUser.Username}: {MessageTextBox.Text}";
            _communicationService.SendChatMessage(message);
            MessageTextBox.Clear();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            _currentUser = null;
            LoginGrid.Visibility = Visibility.Visible;
            MainGrid.Visibility = Visibility.Collapsed;
            UsernameTextBox.Clear();
            PasswordBox.Clear();
        }

        private void OnNotificationReceived(object sender, string message)
        {
            Dispatcher.Invoke(() =>
            {
                MessageBox.Show(message, "Новое уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            });
        }

        private void OnChatMessageReceived(object sender, string message)
        {
            Dispatcher.Invoke(() =>
            {
                ChatMessages.Items.Add(message);
            });
        }
    }
}