using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaCodeFirstApp.Models
{
    public class Loan
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int BookID { get; set; }
        public virtual Book Book { get; set; }
    }
}