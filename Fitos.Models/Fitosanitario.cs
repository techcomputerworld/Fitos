using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitos.Models
{
    public class Fitosanitario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //tipo de fitosanitario
        public string Tipo { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Imagen1")]
        public string UrlImagen { get; set; }
        [Display(Name = "Imagen2")]
        public string UrlImagen2 { get; set; }

        //Llaves foraneas
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        //navigation property
        public ICollection<Mezcla> Mezcla { get; set; }


    }
}
