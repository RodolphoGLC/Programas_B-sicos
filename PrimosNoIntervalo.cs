//Verificando qual dos números dentro do intervalo é primo

int numeroI = 0;
int numeroF = 0;

Console.WriteLine("Programa para escrever os números primos de um intervalo");

Console.WriteLine("Digite um numero para ser o inicio da verificação");
numeroI = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um numero para ser o final da verificação");
numeroF = int.Parse(Console.ReadLine());

for(int i = numeroI; i <= numeroF; i++)
{
    for(int y = 2; y <= i; y++)
    {
       if(i % y == 0)
        {
            if(y == i)
            {
                Console.WriteLine(i + " é primo");
            } 
            else
            {
                break;
            }
        }     
    }
}