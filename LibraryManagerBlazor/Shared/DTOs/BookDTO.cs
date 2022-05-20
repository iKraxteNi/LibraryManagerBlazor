using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBlazor.Shared.DTOs
{


    public class BookDTO
    {


        public long Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }
        public long? CustomerId { get; set; }
        public string? CustomerName { get; set; } 
        public string CategoryName { get; set; }
        public string CoverName { get; set; }

        public virtual CustomerDTO? Customer { get; set; }

    }
}
