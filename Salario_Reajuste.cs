//Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários, regras:
//Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

Double salario = 0;
Double salarioNovo = 0;

for (int i = 0; i < 10; i++)
{
Console.Write("Informe o salário: ");
salario = Convert.ToDouble(Console.ReadLine());
if (salario <= 300)
{ 
    salarioNovo = salario * 1.50;
}
else
{ 
    salarioNovo = salario * 1.30;
}
Console.WriteLine("Salário reajustado: " + salarioNovo);
}