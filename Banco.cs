using System;

namespace ProgramOO
{
    internal class Conta
    {
        private int numeroConta;
        private string titular;
        private float saldo;
        private List<string> extrato = new List<string>();
        public Conta(int numeroConta)
        {
            this.numeroConta = numeroConta;
        }

        public string Titular
        {
            get
            { 
                return this.titular; 
            }
            set { this.titular = value; }
        }

        public void Depositar(float deposito)
        {
            this.extrato.Add($"voce depositou: {deposito}");
            this.saldo += deposito;
        }

        public void Sacar(float saque)
        {
            this.extrato.Add($"voce sacou: {saque}");
            this.saldo -= saque;  
        }
        
        public void Extrato()
        {
            Console.WriteLine("------------EXTRATO-------------");
            foreach (string item in this.extrato)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------");

        }
        public void Info()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"Numero da conta: {this.numeroConta}\tTitular: {this.Titular}\tSaldo: {this.saldo}");
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
    }
}
