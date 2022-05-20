using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace LibraryManagerBlazor.Shared.Entities
{

    public class Book
    {


        public long Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }
        public string CategoryName { get; set; }
        public string CoverName { get; set; }

        public long? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }



    }

}
