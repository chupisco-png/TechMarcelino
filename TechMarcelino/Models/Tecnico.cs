using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using TechMarcelino.Models;

namespace TechMarcelino.Models
{
    public class Tecnico : Pessoa
    {
        public string Matricula { get; set; }
        public string Especialidade { get; set; }

        public Tecnico(string nome, string telefone, string matricula, string especialidade)
            : base(nome, telefone)
        {
            Matricula = matricula;
            Especialidade = especialidade;
        }
    }
}