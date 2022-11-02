//Vc solicita um número e como resposta da o fatorial desse número
//Começa a multiplicar por 1 até chegar no resultado final 
//0!=1, 1!=1, 2!=2, 3!=6, 4!=24

Console.WriteLine("Digite um número para que seja feito o seu fatorial");
int nFatorial = int.Parse(Console.ReadLine());

int fatorial = 1;

for(int i = 1; i <= nFatorial; i++)
{
    fatorial = fatorial * i;
}

Console.WriteLine("O fatorial do número escolhido é " + fatorial);