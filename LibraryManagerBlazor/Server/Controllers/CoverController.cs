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
    public class CoverController : ControllerBase
    {
        private readonly CoverService _coverService;
        private readonly ApplicationDbContext _context;

        public CoverController(CoverService coverService, ApplicationDbContext context)
        {
            _coverService = coverService;
            _context = context;
        }

        [Route("api/cover")]
        [HttpGet]
        public IEnumerable<CoverDTO> Get()
        {
            return _coverService.GetAll().ToArray();
        }
    }
}
