using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        public int UserId { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
        public bool isAdmin { set; get; }
    }
}
