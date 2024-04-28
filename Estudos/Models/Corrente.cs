using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor){
            Saldo += valor;
        }
    }
}