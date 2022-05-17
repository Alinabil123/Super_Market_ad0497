using System;
using System.Collections.Generic;
using System.Text;

namespace Alinabil_ad0497
{
   public class user
    {
        public string username { get; set; }
        public string password { get; set; }

        public user(string name , string password)
        {
            username = name;
            this.password = password;
        }
    }

}
