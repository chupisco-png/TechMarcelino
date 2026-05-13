using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace TechMarcelino.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}