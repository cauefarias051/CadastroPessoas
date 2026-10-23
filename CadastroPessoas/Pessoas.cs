using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public abstract class Pessoas
    {
        public string Nome;
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine("Nome:  " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }

        public Pessoas(string nome,int idade)
            {
            Nome = nome;
            Idade = idade;
            }
        }
    }