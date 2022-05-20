using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace LibraryManagerBlazor.Shared.Entities
{

    public class Customer
    {


        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Mobile { get; set; }



        public virtual IList<Book> Book { get; set; }

    }
}
