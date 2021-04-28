using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fitos.Models
{
    public class Mezclas
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nombre de mezcla")]
        public string NombreMezcla { get; set; }
        //si o no de respuesta.  
        public bool posible { get; set; }
        //EsPosible sirve para dar una explicación de porque la mezcla es posible según el ingeniero agricola
        public string EsPosible { get; set; }
        [Display(Name = "Descripción de mezcla")]
        public string DescripcionMezcla { get; set; }
        //navigation property
        public ICollection<Mezcla> Mezcla { get; set; }


    }
}
