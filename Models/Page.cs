using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Page<T>
    {
        public int CurrentPage { set; get; }
        public int PageSize { set; get; }
        public List<Post> Records { set; get; }
        public int TotalPages { set; get; }
    }
}
