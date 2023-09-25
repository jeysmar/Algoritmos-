// See https://aka.ms/new-console-template for more information

int n;
double soma = 0.0;

Console.Write("Digite um valor inteiro positivo: ");
n = Int32.Parse(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("O valor deve ser positivo.");
}
else
{
    for (int i = 1; i <= n; i++)
    {
        soma += 1.0 / i;
    }

    Console.WriteLine($"A soma é: {soma}");
}


    

