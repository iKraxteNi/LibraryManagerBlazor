using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using LibraryManagerBlazor.Server.Data;
using LibraryManagerBlazor.Shared.Entities;
using LibraryManagerBlazor.Shared.DTOs.FormModels;

namespace LibraryManagerBlazor.Server.Services
{
    public class CustomerService
    {
        public ApplicationDbContext _context;


        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(string name, string adress, string mobile)
        {
            var customer = new Customer()
            {
                Name = name,
                Adress = adress,
                Mobile = mobile,

            };
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }

        public IEnumerable<Customer> GetAll()
        {
            var custamer = _context.Customer.Select(x => new Customer()
            {
                CustomerId = x.CustomerId,
                Name = x.Name,
                Adress = x.Adress,
                Mobile = x.Mobile
            }).ToList();
            return custamer;
        }
        public void AssignBook(long customerId, long bookId)
        {
            var customer = _context.Customer.FirstOrDefault(x => x.CustomerId == customerId);
            var book = _context.Book.FirstOrDefault(x => x.Id == bookId);

            book.CustomerId = customer.CustomerId;
            book.CustomerName = customer.Name;
            book.Available = false;
            _context.SaveChanges();
        }
        public void CustomerReturnBook(string books)
        {
            long bookId = int.Parse(books); 
            var book = _context.Book.FirstOrDefault(x => x.Id == bookId);

            book.CustomerId = null;
            book.CustomerName = null;
            book.Available = true;
            _context.SaveChanges();
        }

    }
}

    

