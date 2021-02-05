using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class FakeUsersService : IUserService
    {
        private List<User> users = new List<User>
        {
             new User{ Username="turkay", Name="Türkay", Password="123", Role=new Role{ Name="User" } },
             new User{ Username="candan", Name="Candan", Password="987", Role=new Role{ Name="Admin"} },
             new User{ Username="hatice", Name="Hatice Köroğlu", Password="666", Role=new Role{ Name="Editor"} },


        };
        public User ValidUser(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
