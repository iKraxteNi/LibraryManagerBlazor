using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBlazor.Shared.DTOs.FormModels
{
    public class BookAddModel
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }
        public long  categoryId { get; set; }

        public long coverId  { get; set; }
    }
}
