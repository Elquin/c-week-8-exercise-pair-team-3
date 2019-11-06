using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SSGeek.Web.DAL;
using SSGeek.Web.Models;

namespace SSGeek.Web.Controllers
{
    public class ForumController : Controller
    {
        private IForumPostDAO forumDAO;

        public ForumController(IForumPostDAO forumDAO)
        {
            this.forumDAO = forumDAO;
        }



        public IActionResult Index()
        {
            IList<ForumPost> posts = forumDAO.GetAllPosts();
            return View(posts);
        }
    }
}