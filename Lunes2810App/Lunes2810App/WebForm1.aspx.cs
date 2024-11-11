using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lunes2810App
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Book[] books =
            {
                new Book{Title="LINQ IN ACTION"},
                new Book{Title="LINQ TO FUN"},
                new Book{Title="LINQ EXTREMA"}
            };

            var titles = books.Where(book=>book.Title.Contains("ACTION")).Select(book=>book.Title);

            GridView1.DataSource = titles;
            GridView1.DataBind();
        }
    }
}