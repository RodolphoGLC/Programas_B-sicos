//Idade de x alunos

int qnt;
int idadeTotal = 0;

Console.WriteLine("Digite a quantidade de alunos que você deseja fazer a média");
qnt = int.Parse(Console.ReadLine());

for(int i = 1; i <= qnt; i++)
{
    int idadeTemporaria = 0;
    Console.WriteLine("Digite a idade do aluno " + i);
    idadeTemporaria = int.Parse(Console.ReadLine());
    idadeTotal = idadeTotal + idadeTemporaria;
}
Console.Clear();

Console.WriteLine("Média da idade de " + qnt + " é igual a " + (idadeTotal/qnt));