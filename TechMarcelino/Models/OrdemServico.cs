using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using TechMarcelino.Models;

namespace TechMarcelino.Models
{
    public class OrdemServico
    {
        public Equipamento Aparelho { get; set; }
        public string DefeitoRelatado { get; set; }
        public string Status { get; private set; }

        public OrdemServico(Equipamento aparelho, string defeito)
        {
            Aparelho = aparelho;
            DefeitoRelatado = defeito;
            Status = "Pendente";
        }
    }
}