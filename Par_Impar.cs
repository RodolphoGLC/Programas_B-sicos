//Crie um algoritmo que verifique se um número informado é par ou impar

double valor;
double resultado;

Console.WriteLine("Digite o valor a ser decoberto");
valor = double.Parse(Console.ReadLine());
Console.Clear();

resultado = valor % 2;

Console.WriteLine("Programa para verificar se o número é par ou impar");
if(resultado == 1)
{
    Console.WriteLine("O valor " + valor + " informado é impar");
}
else
{
    Console.WriteLine("O valor " + valor + " informado é par");
}
