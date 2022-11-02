//Elabore um algoritmo que calcule a idade média de 5 alunos.

double aluno1;
double aluno2;
double aluno3;
double aluno4;
double aluno5;
double media;

Console.WriteLine("Digite a idade do primeiro aluno");
aluno1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a idade do segundo aluno");
aluno2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a idade do terceiro aluno");
aluno3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a idade do quanrto aluno");
aluno4 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a idade do quinto aluno");
aluno5 = double.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine("Programa da idade média dos 5 alunos");
media = (aluno1 + aluno2 + + aluno3 + aluno4 + aluno5)/5;
Console.WriteLine("Idade média dos alunos é igual a " + media);
