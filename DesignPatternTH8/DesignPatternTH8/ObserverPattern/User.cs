using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.Observer
{
    internal class User
    {
        private string username {  get; set; }
        public User(string username)
        {
            this.username = username;
        }
        public string GetUsername()
        {
            return username;
        }
    }
}
