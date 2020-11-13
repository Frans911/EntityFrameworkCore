using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Data.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogUrl { get; set; }
        public List<Post> Posts { get; } = new List<Post>();
    }
}
