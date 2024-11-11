using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogsDBFirst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                InsertBlogAndPost();
                ShowAllBlogsAndPost();

                //UpdatePostTitle();
                //DeletePost();
            }
           
        }

        private void DeletePost()
        {
            throw new NotImplementedException();
        }

        private void UpdatePostTitle()
        {
            throw new NotImplementedException();
        }

        private void ShowAllBlogsAndPost()
        {
            using (var context = new BlogsDBEntities())
            {
                var queryShowAll = context.Posts
                    .Select(p => new
                    {
                        BlogName = p.Blog.Name,
                        BlogURL = p.Blog.Url,
                        PostTitle = p.Title
                    }).ToList();

                gv1.DataSource = queryShowAll;
                gv1.DataBind();
            }
        }

        private void InsertBlogAndPost()
        {
            using (var context = new BlogsDBEntities()) {
                var blog = new Blog {Name = "Cien años de soledad", Url = " https://www.example.com/cien-anos-de-soledad" };
                context.Blogs.Add(blog);
                var post = new Post
                {
                    Title = "La magia del realismo en \"Cien años de soledad\"",
                    Content = "\"Cien años de soledad\" es una de las obras más emblemáticas de la literatura latinoamericana, escrita por el maestro Gabriel García Márquez. Publicada en 1967, esta novela narra la historia de la familia Buendía en el pueblo ficticio de Macondo, un lugar donde la realidad y la fantasía se entrelazan de manera única.\r\n\r\nLa novela aborda temas universales como la soledad, el amor, el poder y la muerte, todo ello envuelto en un estilo de realismo mágico que ha cautivado a lectores de diversas generaciones. A lo largo de sus páginas, Márquez nos invita a explorar la complejidad de las relaciones humanas y el impacto del tiempo en nuestras vidas.\r\n\r\nLos personajes, como Úrsula Iguarán y su esposo José Arcadio Buendía, se convierten en símbolos de la búsqueda interminable de significado y conexión. La narrativa fluida y poética de Márquez, llena de metáforas y simbolismo, hace que cada lectura sea una experiencia nueva y enriquecedora.\r\n\r\nSi aún no has leído esta obra maestra, te animo a que lo hagas. \"Cien años de soledad\" no solo es un viaje a través del tiempo y el espacio, sino también una reflexión profunda sobre la condición humana.",
                    BlogID = blog.BlogID
                };
                context.Posts.Add(post);
                context.SaveChanges();
            };
        }

       
    }
}