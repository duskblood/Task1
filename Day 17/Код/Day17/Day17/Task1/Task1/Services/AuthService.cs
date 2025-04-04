using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Task1.Models;

namespace Task1.Services
{
    public class AuthService
    {
        private readonly DataService _dataService;

        public AuthService(DataService dataService)
        {
            _dataService = dataService;
        }

        public User? AuthenticateUser(string username, string password)
        {
            var users = _dataService.LoadUsers();
            var passwordHash = HashPassword(password);
            
            var user = users.FirstOrDefault(u => 
                u.Username == username && 
                u.PasswordHash == passwordHash);

            if (user != null)
            {
                user.LastLogin = DateTime.Now;
                _dataService.SaveUsers(users);
            }

            return user;
        }

        public bool RegisterUser(User user, string password)
        {
            var users = _dataService.LoadUsers();
            
            if (users.Any(u => u.Username == user.Username))
                return false;

            user.PasswordHash = HashPassword(password);
            users.Add(user);
            _dataService.SaveUsers(users);
            return true;
        }

        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
} 