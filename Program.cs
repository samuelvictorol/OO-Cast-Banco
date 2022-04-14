using System;

namespace ProgramOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REGISTRE SUA NOVA CONTA\nOBS: utilize virgula para centavos\n");

            Console.WriteLine("-> Digite o numero da conta:");
            Conta conta = new Conta(int.Parse(Console.ReadLine()));

            Console.WriteLine("-> Digite o nome do Titular:");
            conta.Titular = Console.ReadLine();

            Console.WriteLine("-> Deseja fazer um deposito inicial ?(s/n)");
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine("-> Digite o valor a ser depositado: ");
                    conta.Depositar(float.Parse(Console.ReadLine()));
                    break;

                case "n":
                    break;

                default:
                    Console.WriteLine("Inválido");
                    return;
                    break;
            }
            Console.Clear();
            conta.Info();
            
            Console.WriteLine("-> Digite o Valor do deposito: ");
            conta.Depositar(float.Parse(Console.ReadLine()));
            conta.Info();

            Console.WriteLine("-> Digite o valor do saque: ");
            conta.Sacar(float.Parse(Console.ReadLine()));
            conta.Info();

            Console.Clear();
            Loading();
            conta.Extrato();

            Console.ReadKey();
        }
        static void Loading()
        {
            Console.WriteLine("Carregando seu Extrato");
            for (int i = 0; i < 10; i++)
            { 
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.Clear();
        }
    }
}