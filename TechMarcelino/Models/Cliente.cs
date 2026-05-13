using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using TechMarcelino.Models;

public class Cliente : Pessoa
{
    public string CPF { get; set; }

    public Cliente(string nome, string telefone, string cpf) : base(nome, telefone)
    {
        CPF = cpf;
    }
}