//Vc entra com as 3 medidas de um triângulo e como resposta tem a classificação dele
//Se é escaleno (tudo diferente), isoceles (2 lados iguais) e equilatero (3 lados iguais)

Console.WriteLine("Digite o lado 1 (a)");
int v1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Digite o lado 2 (b)");
int v2 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Digite o lado 3 (c)");
int v3 = int.Parse(Console.ReadLine()); 
Console.Clear();

//Extra, calcule a área e o volume

double area = 0;
int perimetro = v1 + v2 + v3;
double altura = 0;

Console.WriteLine($"Os lados são {v1}, {v2}, {v3} logo:");

if(v1 == v2 && v2 == v3 && v1 == v3)
{
    Console.WriteLine("O triangulo é equilatero (todos os lados iguais)");
    area = (1.7 / 4) * Math.Pow(v1, 2);
    Console.WriteLine("O perimetro do triangulo é igual a " + perimetro);
    Console.WriteLine("A área do triangulo é igual a " + area);
}
else if(v1 != v2 && v2 != v3 && v1 != v3)
{
    Console.WriteLine("O triangulo é escaleno (todos os lados diferentes)");
    int semiperimetro = perimetro /2;
    area = Math.Sqrt(semiperimetro * (semiperimetro - v1) * (semiperimetro - v2) * (semiperimetro - v3));
    Console.WriteLine("O perimetro do triangulo é igual a " + perimetro);
    Console.WriteLine("A área do triangulo é igual a " + area);
}
else if(v1 == v2 || v2 == v3 || v1 == v3)
{
    Console.WriteLine("O triangulo é isóceles (2 lados iguais)");
    if(v1 == v2)
	{
        altura = Math.Sqrt(Math.Pow(v1,2) - Math.Pow((v3/2),2));
		area = (v3 * altura) / 2;
	}
	else if(v1 == v3)
	{
        altura = Math.Sqrt(Math.Pow(v1,2) - Math.Pow((v2/2),2));
		area = (v2 * altura) / 2;
	}
    else if(v2 == v3)
	{
        altura = Math.Sqrt(Math.Pow(v2,2) - Math.Pow((v1/2),2));
		area = (v1 * altura) / 2;
	}
    Console.WriteLine("O perimetro do triangulo é igual a " + perimetro);
    Console.WriteLine("A área do triangulo é igual a " + area);
}