// Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. 
// O algoritmo deverá ler a idade de 10 pessoas.

int idade;
int qnt = 0;

int i = 0;
while(i < 10 )
{
    i = i + 1;
    Console.WriteLine("Informe a idade da pessoa: ");
    idade = int.Parse(Console.ReadLine());
    if (idade >= 18)
    {
        qnt = qnt + 1;
    }
}

Console.WriteLine("A quantidade de pessoas maiores de 18 anos é " + qnt);
