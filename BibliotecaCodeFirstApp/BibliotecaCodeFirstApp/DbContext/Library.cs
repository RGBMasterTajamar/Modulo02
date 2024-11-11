using BibliotecaCodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace BibliotecaCodeFirstApp.DbContext
{
    public class Library : System.Data.Entity.DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public Library() :base("StringDBContext"){}
    }
}