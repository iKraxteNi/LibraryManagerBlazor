using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBlazor.Shared.DTOs.FormModels
{
    public class AssignBookModel
    {
        public long customerId { get; set; }
        public long bookId { get; set; }
    }
}
