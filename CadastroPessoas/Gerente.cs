using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class Gerente : Funcionario
    {
        public string Departamento;

        public Gerente(
            string nome,
            int idade,
            decimal salario,
            string departamento)
            : base(nome, idade, salario)
        {
            Departamento = departamento;
        }

        public void ExibirDadosGerente()
        {
            Apresentar();
        }

        public override void Apresentar()
        {
            Console.WriteLine("Tipo: Gerente");
            Console.WriteLine("Nome: " + GetNome());
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Salário: " + Salario);
            Console.WriteLine("Bônus: " + CalcularBonus());
            Console.WriteLine("Departamento: " + Departamento);
        }
    }
}