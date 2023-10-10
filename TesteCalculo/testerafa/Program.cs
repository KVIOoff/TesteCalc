using System;

class FolhaDePagamento
{
    static void Main()
    {
        Console.WriteLine("Calcular Folha de Pagamento");

        // Solicitar informações do funcionário
        Console.Write("Nome do funcionário: ");
        string nome = Console.ReadLine();

        Console.Write("Id do funcionário: ");
        string idFuncionario = Console.ReadLine();

        Console.Write("Nome do cargo do funcionário: ");
        string nomeCargo = Console.ReadLine();

        Console.Write("Horas trabalhadas: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Salário por hora: ");
        double salarioHora = Convert.ToDouble(Console.ReadLine());

        double salarioBruto = horasTrabalhadas * salarioHora;

        // Solicitar desconto do INSS
        Console.Write("Desconto do INSS: ");
        double descontoINSS = Convert.ToDouble(Console.ReadLine());

        // Calcular salário líquido após desconto do INSS
        double salarioLiquido = salarioBruto - descontoINSS;

        // Solicitar desconto do Imposto de Renda
        Console.Write("Desconto do Imposto de Renda: ");
        double descontoIR = Convert.ToDouble(Console.ReadLine());

        // Calcular salário líquido após desconto do Imposto de Renda
        salarioLiquido -= descontoIR;

        // Exibir resumo da Folha de Pagamento
        Console.WriteLine("\nResumo da Folha de Pagamento:");
        Console.WriteLine($"Nome do funcionário: {nome}");
        Console.WriteLine($"Id do Funcionário: {idFuncionario}");
        Console.WriteLine($"Nome do cargo do funcionário: {nomeCargo}");
        Console.WriteLine($"Salário Bruto: {salarioBruto.ToString("C")}");
        Console.WriteLine($"Desconto do INSS: {descontoINSS.ToString("C")}");
        Console.WriteLine($"Desconto do Imposto de Renda: {descontoIR.ToString("C")}");
        Console.WriteLine($"Salário Líquido: {salarioLiquido.ToString("C")}");

        Console.ReadLine(); // Aguardar até que o usuário pressione Enter
    }
}
