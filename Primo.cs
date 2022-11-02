//Verificar se é primo ou não - Todo número primo e divisível por 1 e por ele mesmo

int numero = 0;

Console.WriteLine("Digite um número para verificar se o mesmo é primo:");
numero = int.Parse(Console.ReadLine());
Console.Clear();

int primo = 1;

for(int i = 1; i < numero; i++)
{
    if(numero % i == 0)
    {
        primo = primo + 1;
    }
}

if(primo == 2)
{
    Console.WriteLine($"O número {numero} é primo");
}
else
{
    Console.WriteLine($"O número {numero} não é primo");
}