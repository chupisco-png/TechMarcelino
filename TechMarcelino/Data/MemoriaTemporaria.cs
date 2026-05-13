using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using TechMarcelino.Models;

namespace TechMarcelino.Data
{
    public static class MemoriaTemporaria
    {
        public static List<Cliente> Clientes = new List<Cliente>();
        public static List<Equipamento> Equipamentos = new List<Equipamento>();
        public static List<OrdemServico> OrdensServico = new List<OrdemServico>();
    }
}
