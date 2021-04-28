using System;
using System.Collections.Generic;
using System.Text;

namespace Fitos.Models
{
    public class Mezcla
    {
        public int id { get; set; }
        //foreign keys
        public Mezclas Mezclas { get; set; }
        public Fitosanitario Fitos { get; set; }
    }
}
