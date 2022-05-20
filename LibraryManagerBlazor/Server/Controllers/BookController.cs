using AutoMapper;
using LibraryManagerBlazor.Server.Data;
using LibraryManagerBlazor.Server.Services;
using LibraryManagerBlazor.Shared.DTOs;
using LibraryManagerBlazor.Shared.DTOs.FormModels;
using LibraryManagerBlazor.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerBlazor.Server.Controllers
{
    
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly CategoryService _categoryService;
        private readonly CoverService _coverService;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;


        public BookController(BookService bookService, CategoryService categoryService, CoverService coverService, ApplicationDbContext context, IMapper mapper)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            _coverService = coverService;
            _context = context;
            _mapper = mapper;

        }

        [Route("api/book")]
        [HttpGet]
        public IEnumerable<BookDTO> GetBook()
        {
            return _mapper.Map<IEnumerable<BookDTO>>(_bookService.GetAll().ToArray());
        }

        [Route("api/book/availabl")]
        [HttpGet]
        public IEnumerable<BookDTO> GetAvailablBook()
        {
            return _mapper.Map<IEnumerable<BookDTO>>(_bookService.GetAllAvailableBook().ToArray());
        }


        [Route("api/book/add")]   
        [HttpPost]
        public async Task<IActionResult> BookAdd([FromBody] BookAddModel data)
        {
            var cover = _context.Cover
                .FirstOrDefault(x => x.Id == data.coverId);
            var category = _context.Category
                .FirstOrDefault(x => x.Id == data.categoryId);

            var book = new Book
            {
                Author = data.Author,
                Name = data.Name,
                Available = true

            };
            book.CoverName = cover.Name;
            book.CategoryName = category.Name;
            _context.Book.Add(book);
            _context.SaveChanges();

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
