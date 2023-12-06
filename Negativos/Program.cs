using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negativos {
    class Program {
        static void Main(string[] args) {

            int n, i;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("NUMEROS NEGATIVOS:");
            for (i = 0; i < n; i++) {
                if (vet[i] < 0) {
                    Console.WriteLine(vet[i]);
                }
            }

        }
    }
}
