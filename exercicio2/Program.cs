// See https://aka.ms/new-console-template for more information

int num1, num2, num3;

Console.WriteLine("Digite três números:");

Console.Write("Número 1: ");
num1 = Int32.Parse(Console.ReadLine());

Console.Write("Número 2: ");
num2 = Int32.Parse(Console.ReadLine());

Console.Write("Número 3: ");
num3 = Int32.Parse(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
{
    if (num2 >= num3)
    {
        Console.WriteLine($"Ordem decrescente: {num1}, {num2}, {num3}");
    }
    else
    {
        Console.WriteLine($"Ordem decrescente: {num1}, {num3}, {num2}");
    }
}
else if (num2 >= num1 && num2 >= num3)
{
    if (num1 >= num3)
    {
        Console.WriteLine($"Ordem decrescente: {num2}, {num1}, {num3}");
    }
    else
    {
        Console.WriteLine($"Ordem decrescente: {num2}, {num3}, {num1}");
    }
}
else
{
    if (num1 >= num2)
    {
        Console.WriteLine($"Ordem decrescente: {num3}, {num1}, {num2}");
    }
    else
    {
        Console.WriteLine($"Ordem decrescente: {num3}, {num2}, {num1}");
    }
}

Console.ReadLine();
    

    




    
        
        
        




