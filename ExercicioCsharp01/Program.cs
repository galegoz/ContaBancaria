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
            ContaBancaria p1 = new ContaBancaria(12245, "Maria Silva", 500, 0);

            Console.WriteLine(p1.ToString());

            p1.depositar(200);

            p1.saque(100);

            
            

            Console.ReadKey();
        }
    }
}
