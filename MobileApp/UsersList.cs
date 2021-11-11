using System;
using System.Collections.Generic;

namespace MobileApp
{
    public class UsersList
    {
        private static UsersList _UsersList = new UsersList();

        public static UsersList Users
        {
            get { return _UsersList;  }
        }

        public static List<User> usersList = new List<User>();

        public UsersList()
        {
        }
    }
}
