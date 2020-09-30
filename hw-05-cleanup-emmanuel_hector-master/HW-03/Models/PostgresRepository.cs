using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace HW_03.Models
{
    public class PostgresRepository : IRepository
    {
        private readonly ApplicationDbContext context;

        //Task<IEnumerable<Post>> IRepository.PostList => throw new NotImplementedException();

        
    public PostgresRepository(ApplicationDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Post>> GetPostListAsync () {
            return await EntityFrameworkQueryableExtensions.ToListAsync(context.Posts);

            //return await context.Posts.ToListAsync();
        }
        public async Task AddPostAsync(Post post)
        {
            post.PostedOn = DateTime.Now;
            context.Posts.Add(post);
            await context.SaveChangesAsync();
        }

        public async Task EditPostAsync(Post post)
        {
            post.EditedOn = DateTime.Now;
            context.Update(post);
            await context.SaveChangesAsync();
            //await Task.Run(() => context.Posts. = post);
        }

        public async Task<Post> GetPostAsync(int postID)
        {
            //var postlist = await EntityFrameworkQueryableExtensions.ToListAsync(context.Posts);
            //return postlist.Find(x=>x.ID.Equals(postID));
            return await context.Posts.Include(r => r.Comments).FirstOrDefaultAsync(r => r.ID == postID);
        }

        public async Task AddCommentAsync(Comment comment)
        {
            context.Comments.Add(comment);
            await context.SaveChangesAsync();
        }

        public async Task DeleteCommentAsync(Comment comment)
        {
            comment.Deleted = true;
            comment.DeletedOn = DateTime.Now;
            context.Update(comment);
            await context.SaveChangesAsync();
        }

        public async Task AddCategoryAsync (Category category, int postId)
        {

            var tempCat = await EntityFrameworkQueryableExtensions.FirstAsync(context.Categories, c => c.CategoryName == category.CategoryName);


           if(category.CategoryName == null)
            {
                Category = new category1();
                category1.Catagoryname = category.CategoryName;
                category1.CatagoryId = category.CategoryId;
            }
        }

        public async Task<Comment> GetCommentAsync(int commentID)
        {
            return await context.Comments.Include(r => r.ParentPost).FirstOrDefaultAsync(r => r.ID == commentID);
        }

        //public async Task<IEnumerable<Comment>> GetCommentAsync(int PostID)
        //{
        //    var commentlist = await EntityFrameworkQueryableExtensions.ToListAsync(context.Comments);
        //    return (IEnumerable<Comment>)commentlist.Find(x => x.PostID.Equals(PostID));
        //}
    }
}
