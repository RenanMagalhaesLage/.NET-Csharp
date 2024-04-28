using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos.Models
{
    public class Pessoa
    {
        //Construtor logo abaixo de classe --> convenção / padrão
        public Pessoa(){}
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome){
            nome=Nome;
            sobrenome=Sobrenome;
        }
        private string _nome;
        private int _idade;

        public string Nome { 
            get => _nome.ToUpper();
            set{
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public int Idade { 
            get{
                return _idade;
            } 
            set{
                if(value <= 0){
                    throw new ArgumentException("A idade não pode ser menor ou igual a zero");
                }
                _idade = value;
            } 
        }

        public string NomeCompleto => Nome + " " + Sobrenome; //Precisou somente do get

        public virtual void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, e tenho {Idade} anos.");
        }
    }
}