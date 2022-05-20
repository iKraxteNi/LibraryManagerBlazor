using LibraryManagerBlazor.Server.Data;
using LibraryManagerBlazor.Shared.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagerBlazor.Server.Services
{
    public class CoverService
    {
        private readonly ApplicationDbContext _context;

        public CoverService(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<CoverDTO> GetAll()
        {
            var cover = _context.Cover.Select(x => new CoverDTO()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return cover;
        }
    }
}
