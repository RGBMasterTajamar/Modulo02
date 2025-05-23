﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Lunes2810App
{
    public class Books
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfRelease { get; set; }

        public static List<Books> GetBooks()
        {
            List<Books> list = new List<Books>();
            list.Add(new Books
            {
                ID = "001",
                Title = "Programming in C#",
                Author = "Joe Jackson",
                Price = 634.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            list.Add(new Books
            {
                ID = "002",
                Title = "Learn Jave in 30 days",
                Author = "Bob Robson",
                Price = 250.76m,
                DateOfRelease = Convert.ToDateTime("2011-08-15")
            });

            list.Add(new Books
            {
                ID = "003",
                Title = "Programming in ASP.Net 4.0",
                Author = "Samuel Ker",
                Price = 700.00m,
                DateOfRelease = Convert.ToDateTime("2011-02-05")
            });

            list.Add(new Books
            {
                ID = "004",
                Title = "VB.Net Made Easy",
                Author = "Bob Robson",
                Price = 500.99m,
                DateOfRelease = Convert.ToDateTime("2011-12-31")
            });

            list.Add(new Books
            {
                ID = "005",
                Title = "Programming in C",
                Author = "Irina Gonzlez",
                Price = 314.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            list.Add(new Books
            {
                ID = "006",
                Title = "Programming in C++",
                Author = "Paty Lohan",
                Price = 456.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            list.Add(new Books
            {
                ID = "007",
                Title = "Datebase Developement",
                Author = "Jim Denver",
                Price = 1000.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });
            return list;
        }
    }
}
