using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaseDatosFirst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CreateDatos();
                llenarGrid();
            }
        }

        private void llenarGrid()
        {
            using (var context = new PoetasEFEntities())
            {
                var data = context.Poems
                    .Select(p => new
                    {
                        Poeta = p.Poet.FirstName,
                        Titulo = p.Title,
                        Metrica = p.Meter.MeterName
                    }).ToList();
                gv1.DataSource = data;
                gv1.DataBind();
            }
        }

        private void CreateDatos()
        {
            using(var context = new PoetasEFEntities())
            {
                var poet = new Poet { PoetaID = 1, FirstName = "John", MiddleName = "Cassidy", LastName = "Milton" };
                var poem = new Poem { PoemID = 1, Title = "Paradise Lost" };
                var meter = new Meter { MeterID = 1, MeterName = "Iambic Pentameter" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.Add(poem);

                poem = new Poem { PoemID = 2, Title = "Paradise Regained" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.Add(poem);

                poet = new Poet { PoetaID = 2, FirstName = "Lewis", MiddleName = "C.", LastName = "Carroll" };
                poem = new Poem { PoemID = 3, Title = "The Hunting of the Shark" };
                meter = new Meter { MeterID = 2, MeterName = "Anapestic Tetrameter" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.Add(poem);

                poet = new Poet { PoetaID = 3, FirstName = "Lord", MiddleName = "J.", LastName = "Byron" };
                poem = new Poem { PoemID = 4, Title = "Don Juan" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.Add(poem);
                context.SaveChanges();
            }
        }
    }
}