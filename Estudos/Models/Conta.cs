using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos.Models
{
    public  abstract class Conta
    {
        protected decimal Saldo; //Protected é protegido contra alterações externas porém a classe e suas filhas podem acessar
        public abstract void Creditar(decimal valor); //abstract em métodos --> obriga o model que herda essa classe implementar esse método
        public void ExibirSaldo(){
            Console.WriteLine($"Seu saldo é de: {Saldo}");
        }
    }
}