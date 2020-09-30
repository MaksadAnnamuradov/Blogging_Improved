using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;



namespace HW_03.Models
{

    public class CategoryModel : PageModel

    { 
        private readonly IRepository repository;


        public CategoryModel(IRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException();
        }


        public async Task OnGet()
        { 

            SelectedCategoryName = Request.Query["CatagoryName"].FirstOrDefault();


            Posts = (List<Post>) await repository.GetPostListAsync();


            Categories = await repository.GetCategoriesAsync();

        }


        public string SelectedCategoryName { get; set; }


        public IEnumerable<Post> Posts { get; private set; }


        public IEnumerable<Category> Categories { get; private set; }
    }

}
