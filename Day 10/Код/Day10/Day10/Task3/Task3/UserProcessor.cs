using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class UserProcessor
    {
        private List<User> users;

        public UserProcessor(List<User> users)
        {
            this.users = users;
        }

        public User FindUserByEmail(string email)
        {
            return users.FirstOrDefault(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}
