﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_03.Models
{
    public interface IRepository
    {
        //its not a get or set function unless something changes
        //It is possible 
        public Task<IEnumerable<Post>> GetPostListAsync();

        public Task AddPostAsync(Post post);
        public Task<Post> GetPostAsync(int postID);

        public Task EditPostAsync(Post post);

        public Task AddCommentAsync(Comment comment);

        public Task DeleteCommentAsync(Comment comment);

        public Task<Comment> GetCommentAsync(int commnetID);

        public Task AddCategoryAsync(Category Category, int PostId);

        public Task<IEnumerable<Category>> GetCategoriesAsync();

        
        //public Task<IEnumerable<Comment>> GetCommentAsync(int PostID);
    }
}
 