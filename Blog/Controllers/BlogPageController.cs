using Blog.Interfaces;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class BlogPageController : Controller
    {
        private IAllPosts _posts;

        public BlogPageController(IAllPosts posts)
        {
            _posts = posts;
        }

        public ViewResult Index()
        {
            var viewModel = new BlogPageViewModel
            {
                Posts = _posts.Posts
            };

            return View(viewModel);

        }

    }
}
