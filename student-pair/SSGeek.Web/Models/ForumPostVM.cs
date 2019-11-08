using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSGeek.Web.Models
{
    public class ForumPostVM
    {
        public IList<ForumPost> Posts { get; set; }
        public bool PostSaved { get; set; }
    }
}
