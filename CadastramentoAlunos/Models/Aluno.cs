using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProgramaTeste.Models
{
    public class Aluno
    {
        //Propriedades do aluno
        // public string Nome { get; set; }
        // public string Sobrenome { get; set; }
        // public int Idade { get; set; }

        //Criação da lista
        private List<string> aluno = new List<string>();

        //Metodos a serem concluídos
        public void Cadastrar()
        {
            Console.WriteLine("Seguir o padão: " + "Nome Sobrenome: Idade");
            string alunox = Console.ReadLine();
            aluno.Add(alunox); 
        }
        public void Listar()
        {
            if(aluno.Any())
            {
                foreach(string itens in aluno)
                {
                    Console.WriteLine(itens);
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia");
            }
        }
        public void Remover(){
            Console.WriteLine("Aluno que deseja remover: " + "Nome Sobrenome: Idade");
            string alunox = Console.ReadLine();
            aluno.Remove(alunox);
        }
        public void Encerrar(){
            string serializado = JsonConvert.SerializeObject(aluno, Formatting.Indented); 
            File.WriteAllText("Arquivos/Alunos.json", serializado);
        }
    }
}

