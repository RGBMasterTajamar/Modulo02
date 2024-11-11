using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaCodeFirstApp.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Editorial { get; set; }
        public int NumPages { get; set; }

        public int AuthorID {  get; set; }
        public virtual Author Author { get; set; }
    }
}