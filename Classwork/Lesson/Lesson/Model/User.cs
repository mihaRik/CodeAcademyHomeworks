using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Model
{
    
    class User
    {
        public static int _id = 1;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public DateTime RegisterDate { get; set; }
        public User()
        {

        }
        public User(string _username,string _password,string _email)
        {
            Username = _username;
            Password = _password;
            Email = _email;
            Id = _id;
            _id++;
        }

    }
}
