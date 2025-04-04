using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using Task1.Models;

namespace Task1.Services
{
    public class DataService
    {
        private readonly string _warehousePath = "warehouse.json";
        private readonly string _usersPath = "users.json";

        public List<Product> LoadProducts()
        {
            if (!File.Exists(_warehousePath))
                return new List<Product>();

            var json = File.ReadAllText(_warehousePath);
            return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

        public void SaveProducts(List<Product> products)
        {
            var json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_warehousePath, json);
        }

        public List<User> LoadUsers()
        {
            if (!File.Exists(_usersPath))
                return new List<User>();

            var json = File.ReadAllText(_usersPath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public void SaveUsers(List<User> users)
        {
            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_usersPath, json);
        }
    }
} 