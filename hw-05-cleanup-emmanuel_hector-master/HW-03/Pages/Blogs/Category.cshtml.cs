using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using HW_03.Models;


namespace Blog.Pages
{
    public class  PostCatModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public PostCatModel(ApplicationDbContext context)
        {
            _context = context;
        }

       

        [BindProperty]
        public IEnumerable<Category> Category { get; set; }

        public IActionResult OnGet(IEnumerable<Category> cat)
        {
            Category = cat;
            return Page();
        }

    }

}
