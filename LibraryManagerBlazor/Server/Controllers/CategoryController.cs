using LibraryManagerBlazor.Server.Data;
using LibraryManagerBlazor.Server.Services;
using LibraryManagerBlazor.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagerBlazor.Server.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        private readonly ApplicationDbContext _context;

        public CategoryController(CategoryService categoryService, ApplicationDbContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        [Route("api/category")]
        [HttpGet]
        public IEnumerable<CategoryDTO> Get()
        {
            
            return _categoryService.GetAll().ToArray();
        }

    }
}
