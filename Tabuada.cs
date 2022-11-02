//Programa para fazer a tabuada

using System; 

//Declaração do valor e a sua conversão de string pra int 
int valor;
Console.WriteLine("Digite um valor para conhecer a sua tabuada");
valor = int.Parse(Console.ReadLine());

//Painel declarando a tabuada
Console.Clear();
Console.WriteLine($"Tabuada do {valor}");

//Declaração do resultado que passará pelo contador
int resultado;

//Contador da tabuada
for(int contador = 0; contador <= 10; contador++)
{
    resultado = valor * contador;
    Console.WriteLine($"{valor} x {contador} = "+ resultado);
}