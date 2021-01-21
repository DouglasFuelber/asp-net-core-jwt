using Shop.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, Username = "batman", Password = "batman", Role = "admin" },
                new User { Id = 2, Username = "robin", Password = "robin", Role = "employee" },
                new User { Id = 2, Username = "joker", Password = "joker", Role = "manager" }
            };

            return users.Where(x => x.Username.ToLower() == username.ToLower()
                                    && x.Password == x.Password)
                        .FirstOrDefault();
        }
    }
}
