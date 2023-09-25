// See https://aka.ms/new-console-template for more information

int lado;

Console.Write("Digite o tamanho do lado do quadrado (entre 1 e 20): ");

lado = Int32.Parse(Console.ReadLine());

if (lado >= 1 && lado <= 20)
{
    for (int i = 0; i < lado; i++)
    {
        for (int j = 0; j < lado; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Tamanho do lado inválido. Deve ser entre 1 e 20.");
}

Console.ReadLine();
    

