﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGeek.Web.Models
{
    public class ForumPost
    {
        public string UserName { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime PostDate { get; set; }
    }
}
