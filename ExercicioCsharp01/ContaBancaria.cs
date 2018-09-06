using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCsharp01
{
    class ContaBancaria
    {
        private int numConta;
        private String nome;
        private double deposito;
        private double saldo;

        public ContaBancaria(int numConta, String nome, double deposito, double saldo)
        {
            this.numConta = numConta;
            this.nome = nome;
            this.deposito = deposito;
            this.saldo = deposito;
        }

        public ContaBancaria(int numConta, String nome, double saldo)
        {
            this.numConta = numConta;
            this.nome = nome;
            this.saldo = 0;
        }

        public void depositar(int valor)
        {
            this.saldo = this.saldo + valor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Depósito realizado com sucesso!!!");
            Console.Beep();
            Console.WriteLine("Novo saldo R${0}", Saldo.ToString("F2"));
            Console.ReadKey();
            Console.ResetColor();

        }

        public void saque(int valor)
        {
            this.saldo = this.saldo - valor - 5.00;
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Saque realizado com sucesso!!!");
            Console.Beep();
            Console.WriteLine("Novo saldo:" + Saldo);
        }

        public override string ToString()
        {
            return "Conta: " + NumConta + "\nTitular: " + nome + "\nSaldo:" + saldo;
        }


        public int NumConta { get => numConta; }
        public string Nome { get => nome; set => nome = value; }
        public double Deposito { get => deposito; set => deposito = value; }
        public double Saldo { get => saldo; set => saldo = value; }
    }
}
