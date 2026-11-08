using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class Cliente : Pessoas
    {
        public string CodigoCliente { get; set; }

        public void ExibirDadosCliente()
        {
            Apresentar();
        }

        public override void Apresentar()
        {
            Console.WriteLine("Tipo: Cliente");
            Console.WriteLine("Nome: " + GetNome());
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Código: " + CodigoCliente);
        }

        public Cliente(string nome, int idade, string codigoCliente)
            : base(nome, idade)
        {
            CodigoCliente = codigoCliente;
        }
    }
}