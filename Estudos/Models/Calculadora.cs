using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Estudos.Interfaces;

namespace Estudos.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int num1, int num2){
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2){
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2){
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            return num1 * num2;
        }

        public int Dividir(int num1, int num2){
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            return num1 / num2;
        }
        
        public void Potencia(int num1, int num2){
            double pot = Math.Pow(num1,num2);
            Console.WriteLine($"{num1}^{num2} = {pot}");
        }

        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno({angulo}°) = {Math.Round(seno,4)}");
        }

        public void Cosseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cos({angulo}°) = {Math.Round(cosseno,4)}");
        }

        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tan({angulo}°) = {Math.Round(tangente,4)}");
        }
    }
}