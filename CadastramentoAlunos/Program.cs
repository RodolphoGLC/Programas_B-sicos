using System;
using ProgramaTeste.Models;
using Newtonsoft.Json;

Aluno aluno = new Aluno();

//string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar Aluno");
    Console.WriteLine("2 - Listar Alunos");
    Console.WriteLine("3 - Remover");
    Console.WriteLine("4 - Encerrar");


    switch(Console.ReadLine())
    {
        case "1":
            aluno.Cadastrar();
            break;
        case "2":
            aluno.Listar();
            break;
        case "3":
            aluno.Remover();
            break;
        case "4":
            aluno.Encerrar();
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");

















// //Criar alunos

// Aluno a1 = new Aluno("Rodolpho", "Coutinho", 20);

// Console.WriteLine(a1);
