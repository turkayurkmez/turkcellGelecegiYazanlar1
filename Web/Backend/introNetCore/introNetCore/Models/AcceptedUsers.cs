using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introNetCore.Models
{
    public static class AcceptedUsers
    {
        public static List<UserResponse> incomingUsers = new List<UserResponse>();
        public static void Add(UserResponse userResponse)
        {
            incomingUsers.Add(userResponse);
        }

    }
}
