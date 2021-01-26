using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Post
    {
        public int PostId { set; get; }
        public string Body { set; get; }
        public List<Comment> Comments { set; get; }
        public DateTime CreatedDate { set; get; }
        public string Header { set; get; }
        public List<Tag> Tags { set; get; }
    }
}
