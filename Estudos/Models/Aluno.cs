using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos.Models
{
    public class Aluno : Pessoa //herança
    {
        public double Nota { get; set; }

        public Aluno(string nome, string sobrenome) : base(nome, sobrenome)
        {

        }
        public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, sou aluno nota {Nota}.");
        }
    }
}