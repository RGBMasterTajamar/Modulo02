//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaseDatosFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Poem
    {
        public int PoemID { get; set; }
        public int PoetID { get; set; }
        public string Title { get; set; }
        public int MeterID { get; set; }
    
        public virtual Meter Meter { get; set; }
        public virtual Poet Poet { get; set; }
    }
}
