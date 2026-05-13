using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace TechMarcelino.Models
{
    public class Equipamento
    {
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public Cliente Dono { get; set; }
    }
}