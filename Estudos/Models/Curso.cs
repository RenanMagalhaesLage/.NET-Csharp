using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }
        public void RemoverAluno(Pessoa aluno){
            Alunos.Remove(aluno);
        }
        public int QtdAlunos(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public void ListarAlunos(){
            Console.WriteLine($"Alunos matriculados no curso de {Nome}");
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine($" - {aluno.NomeCompleto}");
            }
        }
    }
}