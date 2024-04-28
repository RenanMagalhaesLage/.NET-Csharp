using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        public Calculadora()
        {
            listaHistorico = new List<string>();
        }
        public int somar(int num1, int num2)
        {
            listaHistorico.Insert(0,"Somar --> " + num1 + " + " + num2);
            return num1 + num2;
        }

        public int subtrair(int num1, int num2)
        {
            listaHistorico.Insert(0,"Subtrair --> " + num1 + " + " + num2);
            return num1 - num2;
        }

        public int multiplicar(int num1, int num2)
        {
            listaHistorico.Insert(0,"Multiplicar --> " + num1 + " + " + num2);
            return num1 * num2;
        }

        public int dividir(int num1, int num2)
        {
            listaHistorico.Insert(0,"Dividir --> " + num1 + " + " + num2);
            return num1 / num2;
        }

        public double Potencia(int num1, int num2){
            listaHistorico.Insert(0,"Potência --> " + num1 + " ^ " + num2);
           return (Math.Pow(num1,num2)); //num1 ^ num2
        }

        public double Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            double result = Math.Round(seno,4);
            listaHistorico.Insert(0,"Seno(" + angulo+"°) = "+result);
            return result;
        }

        public double Cosseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            double result = Math.Round(cosseno,4);
            listaHistorico.Insert(0,"Cos(" + angulo+"°) = "+result);
            return result;
        }

        public double Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            double result = Math.Round(tangente,4);
            listaHistorico.Insert(0,"Tan(" + angulo+"°) = "+result);
            return result;
        }

        public List<string> historico()
        {
            List<string> res;
            listaHistorico.RemoveRange(3,(listaHistorico.Count-3));
            return listaHistorico;
        }
    }
}