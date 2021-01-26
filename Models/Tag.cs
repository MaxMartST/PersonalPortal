using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Tag
    {
        public int TagId { set; get; }
        public int PostId { set; get; }
        public string TagName { set; get; }
    }
}
