using LibraryManagerBlazor.Server.Data;
using LibraryManagerBlazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibraryManagerBlazor.Shared.DTOs.FormModels;
using System.Globalization;

namespace LibraryManagerBlazor.Server.Services
{
    public class BookService
    {
        private readonly ApplicationDbContext _context;


        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Book> GetAllAvailableBook()
        {
            var book = _context.Book.Where(y => y.Available == true).Select(x => new Book()
            {
                Id = x.Id,
                Name = x.Name,
                Author = x.Author
            }).ToList();
            return book;
        }
        public IEnumerable<Book> GetAll()
        {
            var book = _context.Book.Select(x => new Book()
            {

                Id = x.Id,
                Name = x.Name,
                Author = x.Author,
                CategoryName = x.CategoryName,
                CoverName = x.CoverName

            }).ToList();
            return book;

        }



        public IEnumerable<Book> GetRentedBook()
        {
            var book = _context.Book.Where(y => y.Available == false).Select(x => new Book()
            {
               Id = x.Id,
                Name = x.Name,
                Author = x.Author,
                CustomerName = x.CustomerName
            }).ToList();
            return book;
        }
    }
}
