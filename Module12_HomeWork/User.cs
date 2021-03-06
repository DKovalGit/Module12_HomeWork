using System;
using System.Collections.Generic;
using System.Text;

namespace Module12_HomeWork
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }
    }
}
