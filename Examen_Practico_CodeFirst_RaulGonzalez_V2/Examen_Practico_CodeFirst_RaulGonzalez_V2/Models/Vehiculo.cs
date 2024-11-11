using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examen_Practico_CodeFirst_RaulGonzalez_V2.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        [Key]
        public int VehiculoID { get; set; }
        public string VehicleMat {  get; set; }
        public string VehicleModel { get; set; }
        public string VehicleBrand { get; set; }

        public int PersonaID { get; set; }
        public virtual Persona Persona { get; set; }

        public virtual ICollection<Multa> Multas { get; set; }
        public virtual ICollection<VehiculoAccidente> VehiculoAccidente { get; set; }
    }
}