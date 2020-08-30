using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_UWP.Models
{
   public  class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public int CategoryID { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
