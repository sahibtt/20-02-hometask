using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class User
    {
        private string _username;
        private string _password;
        public User()
        {
            Console.WriteLine("Sisteme Xosh gelmishsiniz!");
        }

        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length < 8)
                {
                    throw new Exception("Minimum 8 simvoldan ibaret olmalidir!");
                }
                value = _username;

            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length < 8)
                {
                    throw new Exception("Minimum 8 simvoldan ibaret olmalidir!");
                }
                value = _password;
            }
        }

    }
}
