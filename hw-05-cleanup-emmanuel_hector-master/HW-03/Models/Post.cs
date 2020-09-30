using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_03.Models
{
    public class Post
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime PostedOn { get; set; }

        public DateTime? EditedOn { get; set; }

        public List<Comment> Comments { get; set; }

        public List<PostCategory> PostCategories { get; set; }


    }
}
