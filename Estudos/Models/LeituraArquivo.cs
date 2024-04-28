using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho){ //retornando uma tupla
            try{
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }catch{
                return(false,new string[0],0);
            }

        }
    }
}