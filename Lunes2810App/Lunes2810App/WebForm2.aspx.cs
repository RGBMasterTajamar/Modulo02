using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Lunes2810App
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Book[] books =
            //{
            //    new Book{Title="LINQ IN ACTION"},
            //    new Book{Title="LINQ TO FUN"},
            //    new Book{Title="LINQ EXTREMA"}
            //};

            //var titles = books.Where(book => book.Title.Contains("ACTION")).Select(book => book.Title);

            //GridView1.DataSource = titles;



            //var books = Books.GetBooks().Select((book, index)=> new
            //{
            //    index, book.Title
            //}).OrderBy(book => book.Title);


            //var authors = (from book in Books.GetBooks()
            //              select new
            //              {
            //                  Autor = book.Author
            //              }).Distinct();
            //GridView1.DataSource = authors.ToList();


            // FUNCIONES DE AGREGADO
            //var minPrice = Books.GetBooks().Min(book => book.Price);
            //var maxPrice = Books.GetBooks().Max(book => book.Price);
            //var totalPrice = Books.GetBooks().Sum(book => book.Price);
            //var avgPrice = Books.GetBooks().Average(book => book.Price);
            //var librosBaratos = Books.GetBooks().Where(book => book.Price < 50).Count();

            //txtDato.Text = minPrice.ToString();
            //txtDato.Text = librosBaratos.ToString();


            //var librosOrdenados = (from book in Books.GetBooks()
            //                      orderby book.Author, book.Price descending, book.Title
            //                      select new
            //                      {
            //                          Autor = book.Author,
            //                          Precio = book.Price,
            //                          Title = book.Title
            //                      }).ToList();
            //GridView1.DataSource = librosOrdenados;


            // Joins
            //var data = (from publisher in SampleData.Publishers
            //           join book in SampleData.Books
            //           on publisher equals book.Publisher
            //           select new
            //           {
            //               Editores = publisher.Name,
            //               Libros = book.Title
            //           }).ToList();
            //GridView1.DataSource = data;

            //var dataLambda = SampleData.Publishers.Join(SampleData.Books,
            //        publisher => publisher,
            //        book => book.Publisher,
            //        (publisher, book) => new
            //        {
            //            Editores = publisher.Name,
            //            Libros = book.Title
            //        }
            //    ).ToList();
            //GridView1.DataSource = dataLambda;


            //var data = (from publisher in SampleData.Publishers
            //           join book in SampleData.Books on publisher equals book.Publisher
            //           join subject in SampleData.Subjects on book.Subject equals subject
            //           select new 
            //           { 
            //               Editor = publisher.Name,
            //               Libro = book.Title,
            //               Tema = subject.Name
            //           }).ToList();

            //GridView1.DataSource = data;

            // Ejemplo de LEFT JOIN
            //GridView1.DataSource = (from publisher in SampleData.Publishers
            //                        join book in SampleData.Books
            //                        on publisher equals book.Publisher into publisherBooks
            //                        from book in publisherBooks.DefaultIfEmpty()
            //                        select new
            //                        {
            //                            Editores = publisher.Name,
            //                            Libros = book == default(Book) ? "(NO books)" : book.Title
            //                        }).ToList();


            //GridView1.DataBind();

            // Paginacion
            // se usan dos funciones
            // SKIP (salta un numero determinado de elementos desde una secuencia),
            // TAKE (muestra un numero dado de elementos)

            if (!IsPostBack)
            {
                GridViewCompleto.DataSource = SampleData.Books
                    .Select((book, index) => new
                    {
                        Index = index,
                        Book = book.Title,
                    }).ToList();

                GridViewCompleto.DataBind();

                int count = SampleData.Books.Count();
                for (int i = 0; i < count; i++)
                {
                    ddlStart.Items.Add(i.ToString());
                    ddlEnd.Items.Add(i.ToString());
                }

                ddlStart.SelectedIndex = 2;
                ddlEnd.SelectedIndex = 3;


                DisplayPartialData();
            }


        }

        private void DisplayPartialData()
        {
            int startIndex = int.Parse(ddlStart.SelectedValue);
            int endIndex = int.Parse(ddlEnd.SelectedValue);

            GridViewPartial.DataSource = SampleData.Books.Select((book,index)=> new
            {
                Index = index,
                book = book.Title
            }).Skip(startIndex).Take(endIndex - startIndex+1).ToList();

            GridViewPartial.DataBind();
        }

        protected void ddlStart_SelectedIndexChanged(object sender, EventArgs e)
        {

            DisplayPartialData();
        }

        protected void ddlEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int startIndex = int.Parse(ddlStart.SelectedValue);
            int endIndex = int.Parse(ddlEnd.SelectedValue);

            if (endIndex >= startIndex)
            {
                DisplayPartialData();
            }
        }
    }
}