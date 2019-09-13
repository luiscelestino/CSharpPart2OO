using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06B_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Titular = new Cliente();

            conta.Titular.Nome = "Chico Bento";
            conta.Titular.CPF = "123.456.789-09";
            conta.Titular.Profissao = "Desenvolvedor .NET";
            conta.Agencia = 123;
            conta.Numero = 123456;
            conta.Saldo = 1000;

            conta.Sacar(200);

            Console.WriteLine("Nome do Titular: " + conta.Titular.Nome);
            Console.WriteLine("CPF do Titular: " + conta.Titular.CPF);
            Console.WriteLine("Profissão do Titular: " + conta.Titular.Profissao);
            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Número: " + conta.Numero);
            Console.WriteLine("Saldo: " + conta.Saldo.ToString("C", CultureInfo.CurrentCulture));

            Console.ReadKey();
        }
    }
}
