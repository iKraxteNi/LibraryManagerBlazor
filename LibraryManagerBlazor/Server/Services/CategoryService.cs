using LibraryManagerBlazor.Server.Data;
using LibraryManagerBlazor.Shared.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagerBlazor.Server.Services
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<CategoryDTO> GetAll()
        {
            var categories = _context.Category.Select(x => new CategoryDTO()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return categories;
        }

    }
}
