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

namespace LibraryManagerBlazor.Server.Controllers
{
    
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly CustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ApplicationDbContext context, CustomerService customerService, IMapper mapper)
        {
            _context = context;
            _customerService = customerService;
            _mapper = mapper;
        }

        [Route("api/customer")]
        [HttpGet]
        public IEnumerable<CustomerDTO> GetCustomers()
        {
            return _mapper.Map<IEnumerable<CustomerDTO>>(_customerService.GetAll().ToArray());
        }

        [Route("api/customer/add")]
        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerAddModel data)
        {
            var customer = new Customer
            {

                Name = data.Name,
                Adress = data.Adress,
                Mobile = data.Mobile,
            };
            _context.Customer.Add(customer);
            _context.SaveChanges();
            return Ok();
        }

        [Route("api/customer/assignbook")]
        [HttpPost]
        public IActionResult BookAssignCustomer([FromBody] AssignBookModel data)
        {
            _customerService.AssignBook(data.customerId, data.bookId);
            return Ok();
        }
    }
}

