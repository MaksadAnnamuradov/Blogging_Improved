using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HW_03.Models;

namespace HW_03.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        private IRepository _repository;

        public IRepository PostgresRepository => _repository;

        public BlogController(ILogger<BlogController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<IActionResult> Posts()
        {
            return View(await _repository.GetPostListAsync());
        }
        public async Task<IActionResult> Categories()
        {
            return View(await _repository.GetCategoriesAsync());
        }

        public async Task<IActionResult> PostCategory(int ID)
        {
            var postlist = await _repository.GetPostListAsync();
            var category = await _repository.GetCategoryAsync(ID);

            var model = new PostCatRel
            {
                posts = postlist,
                category = category
            };
            return View(model);
        }


        public async Task<IActionResult> Detail(int ID)
        {
            var post = await _repository.GetPostAsync(ID);
            return View(post);
        }

        [HttpGet]
        public IActionResult NewPost()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewPost(Post post)
        {
            //var postlist = await _repository.GetPostListAsync();
            //post.ID = postlist.Count();
            await _repository.AddPostAsync(post);

            return View("Posts", await _repository.GetPostListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int ID)
        {

            var post = await _repository.GetPostAsync(ID);
            return View(post);
            //return View((Repository.PostList, ID));
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Post post)
        {
            await Task.Run(() => _repository.EditPostAsync(post));
            return RedirectToAction(nameof(Posts));
        }

        [HttpGet]
        public IActionResult NewComment(int ID)
        {
            return View(ID);
        }

        [HttpPost]
        public async Task<IActionResult> NewComment(Comment comment)
        {
            await _repository.AddCommentAsync(comment);
            return RedirectToAction("Detail", new { ID = comment.PostID });
        }

        public async Task<IActionResult> DeleteComment(int commentId)
        {
            Comment comment = await _repository.GetCommentAsync(commentId);
            await _repository.DeleteCommentAsync(comment);
            return RedirectToAction("Detail", new { ID = comment.PostID });
        }


        public async Task <IActionResult> AddCategory(Category category, int PostId)
        {
            
            await _repository.AddCategoryAsync(category, PostId);
            return RedirectToAction("Detail", new { ID = PostId });

        }

    }
}
