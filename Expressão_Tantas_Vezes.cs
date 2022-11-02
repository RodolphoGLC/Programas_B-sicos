//Programa para somar uma expressão com um valor determinado de x, porém quer fazer a mesma conta N vezes

double numerovezes = 0;
double x = 0; //Futuramente será o número de vezes
double conta = 0;

Console.WriteLine("Digite o número de vezes");
numerovezes = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de x");
x = double.Parse(Console.ReadLine());

for(int i = 0; i < numerovezes; i++)
{
    conta = 3*x*4+5*x-8*x;
    x = conta;
}

Console.WriteLine("Valor final é igual a " + x);