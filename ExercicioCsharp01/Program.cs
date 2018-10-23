using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCsharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string n;
            int numConta;

            ContaBancaria obj;

            Console.WriteLine("BANCO DO BRASIL");

            do
            {
                Console.WriteLine("1 - Criar Conta\n2 - Depositar\n3 - Sacar");

                Console.WriteLine("Escolha a opção:");
                num = int.Parse(Console.ReadLine());


            } while (num < 0 || num > 3);

            if (num == 1)
            {
                Console.WriteLine("CRIAR CONTA");

                Console.WriteLine("Digite o nome:");
                n = Console.ReadLine();

                Console.WriteLine("Digite o numero da conta:");
                numConta = int.Parse(Console.ReadLine());

                obj = new ContaBancaria(numConta, n, 0);
            }
            
            

            Console.ReadKey();
        }
    }
}
//ContaBancaria p1 = new ContaBancaria(12245, "Maria Silva", 500, 0);

//Console.WriteLine(p1.ToString());

//p1.depositar(200);

//p1.saque(100);