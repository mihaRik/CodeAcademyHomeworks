using Lesson.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Database
{
     class UsersDatabase
    {
        public static List<User> users = new List<User>()
        {
            new User(){Id=1,Username="samir",Password="123456",UserType="Admin",RegisterDate=DateTime.Now},
            new User(){Id=2,Username="feride",Password="1456",UserType="Editor",RegisterDate=DateTime.Now},
            new User(){Id=3,Username="rehim",Password="78945",UserType="User",RegisterDate=DateTime.Now},
            new User(){Id=4,Username="elgun",Password="12545",UserType="Admin",RegisterDate=DateTime.Now},
            new User(){Id=5,Username="emin",Password="213",UserType="User",RegisterDate=DateTime.Now},
            new User(){Id=6,Username="asef",Password="123",UserType="User",RegisterDate=DateTime.Now}
        };
    }
}
