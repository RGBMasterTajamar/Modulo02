namespace BibliotecaCodeFirstApp.Migrations
{
    using BibliotecaCodeFirstApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BibliotecaCodeFirstApp.DbContext.Library>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BibliotecaCodeFirstApp.DbContext.Library context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var authors = new List<Author>
            {
                new Author {Name = "Maldini"},
                new Author {Name = "Juan Luis Guerra"},
                new Author {Name = "Pepe Viyuela"},
                new Author {Name = "Antonio Lobato"}
            };
            authors.ForEach(author => context.Authors.AddOrUpdate(a=>a.Name,author));
            context.SaveChanges();


            var books = new List<Book>
            {
                new Book {Title = "La teoria del futbol", ISBN = "11111111", Editorial = "Me gusta el futbol", NumPages=450, AuthorID=1},
                new Book {Title = "La teoria del cancion", ISBN = "12232322", Editorial = "Me gusta la musica", NumPages=230, AuthorID=2},
                new Book {Title = "Aida", ISBN = "113321111", Editorial = "Aida", NumPages=350,AuthorID=3},
                new Book {Title = "La teoria del F1", ISBN = "13343111", Editorial = "Me gusta el futbol", NumPages=950, AuthorID=4}
            };
            books.ForEach(book => context.Books.AddOrUpdate(b => b.Title, book));
            context.SaveChanges();

            var loans = new List<Loan>
            {
                new Loan {
                    StartDate = new DateTime(2023,02,08),
                    EndDate = new DateTime(2023,02,22),
                    BookID = 1
                },
                new Loan {
                    StartDate = new DateTime(2022,12,02),
                    EndDate = new DateTime(2023,01,01),
                    BookID = 2
                },
                new Loan {
                    StartDate = new DateTime(2023,12,02),
                    EndDate = new DateTime(2024,01,01),
                    BookID = 3
                },
                new Loan {
                    StartDate = new DateTime(2024,12,02),
                    EndDate = new DateTime(2025,01,01),
                    BookID = 4
                }
                
            };
            loans.ForEach(loan => context.Loans.AddOrUpdate(l => l.StartDate, loan));
            context.SaveChanges();

        }
    }
}
