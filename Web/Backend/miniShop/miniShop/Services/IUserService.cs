using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
   public interface IUserService
    {
        User ValidUser(string username, string password);
    }
}
