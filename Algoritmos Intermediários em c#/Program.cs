// See https://aka.ms/new-console-template for more information

{
    Int32 numero1, numero2, numero3;

    Console.WriteLine("Digite o numero 1: ");
    numero1 = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Digite o numero 2: ");
    numero2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o numero 3: ");
     numero3 = Convert.ToInt32(Console.ReadLine());

    if (numero1 > numero2)
    {
        if (numero1 > numero3)
        {
            Console.WriteLine("O numero" + numero1+ "e maior");
        }
        else
        {
            Console.WriteLine("O numero"+numero3+ "e maior");
        }
    }
    else
    {
        if (numero2 > numero3)
        {
            Console.WriteLine("O numero "+ numero2 + "e maior");
        }
        else
        {
            Console.WriteLine("O numero" + numero3, "e maior");
        }
    }

    if (numero1 < numero2)
    {
        if (numero1 < numero3)
        {
            Console.WriteLine("O numero" + numero1, "e menor");
        }
        else
        {
            Console.WriteLine("O mumero" + numero2, "e menor");
        }
    }
    else
    {
        if (numero2 < numero3)
        {
            Console.WriteLine("O numero"+ numero2,"e menor");
        }
        else
        {
            Console.WriteLine("O numero"+ numero3,"e menor");
        }
    }


}
