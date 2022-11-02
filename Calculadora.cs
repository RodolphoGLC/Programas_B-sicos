double v1;
double v2;
string tmp;

Console.WriteLine("Digite 1 valor");
tmp = Console.ReadLine();
v1 = int.Parse(tmp);

Console.WriteLine("Digite 1 valor");
tmp = Console.ReadLine();
v2 = int.Parse(tmp);

Console.Clear();
Console.WriteLine("Digite a sua opção");
Console.WriteLine("Caso 0 irá +");
Console.WriteLine("Caso 1 irá -");
Console.WriteLine("Caso 2 irá *");
Console.WriteLine("Caso 3 irá / e %");
Console.WriteLine("Caso 4 irá %");

string opcao = Console.ReadLine();

switch (opcao)
{
    case "0": 
        Console.WriteLine($"{v1} + {v2}");
        Console.WriteLine("Soma = " + (v1 + v2));
        break;
    case "1": 
        Console.WriteLine($"{v1} - {v2}");
        Console.WriteLine("Subtração = " + (v1 - v2));
        break;
    case "2": 
        Console.WriteLine($"{v1} * {v2}");
        Console.WriteLine("Multiplicação = " + (v1 * v2));
        break;
    case "3": 
        Console.WriteLine($"{v1} / {v2}");
        Console.WriteLine("Divisão = " + (v1 / v2));
        Console.WriteLine("Resto = " + (v1 % v2));
        break;
    case "4": 
        Console.WriteLine($"{v1} % {v2}");
        Console.WriteLine("Resto = " + (v1 % v2));
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}