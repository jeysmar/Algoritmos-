// See https://aka.ms/new-console-template for more information

double valorHora, salarioBruto, salarioLiquido, impostoRenda, sindicato, fgts;
int horasTrabalhadas;

Console.WriteLine("Cálculo de Folha de Pagamento\n");

Console.Write("Digite o valor da sua hora de trabalho: ");
valorHora = Double.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de horas trabalhadas no mês: ");
horasTrabalhadas = Int32.Parse(Console.ReadLine());

salarioBruto = valorHora * horasTrabalhadas;

impostoRenda = CalculaImpostoRenda(salarioBruto);
sindicato = salarioBruto * 0.03;
fgts = salarioBruto * 0.11;

salarioLiquido = salarioBruto - impostoRenda - sindicato;

Console.WriteLine("\n Folha de Pagamento ");
Console.WriteLine("Salário Bruto: R$" + salarioBruto.ToString("F2"));
Console.WriteLine("Desconto Imposto de Renda: R$" + impostoRenda.ToString("F2"));
Console.WriteLine("Desconto Sindicato: R$" + sindicato.ToString("F2"));
Console.WriteLine("FGTS: R$" + fgts.ToString("F2"));
Console.WriteLine("Salário Líquido: R$" + salarioLiquido.ToString("F2"));

Console.ReadLine();

static double CalculaImpostoRenda(double salarioBruto)
{
    double impostoRenda;

    if (salarioBruto <= 1903.98)
    {
        impostoRenda = 0;
    }
    else if (salarioBruto <= 2826.65)
    {
        impostoRenda = salarioBruto * 0.075;
    }
    else if (salarioBruto <= 3751.05)
    {
        impostoRenda = salarioBruto * 0.15;
    }
    else if (salarioBruto <= 4664.68)
    {
        impostoRenda = salarioBruto * 0.225;
    }
    else
    {
        impostoRenda = salarioBruto * 0.275;
    }

    return impostoRenda;
}

