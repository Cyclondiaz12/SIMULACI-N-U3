using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace Simulación_U3
{
    internal class EJ611
    {
        static void Main()
        {
            double prob1 = 0.95; // P(X > x) = 0.95
            double prob2 = 0.33; // P(X < y) = 0.33
            double prob3 = 0.77; // P(X < 12) = 0.77
            double prob4 = 0.84; // P(X > 7) = 0.84

            // Z
            double valZ1 = Normal.InvCDF(0, 1, 1 - prob1); // Para P(X > x)
            double valZ2 = Normal.InvCDF(0, 1, prob2); // Para P(X < y)
            double valZ3 = Normal.InvCDF(0, 1, prob3); // Para P(X < 12)
            double valZ4 = Normal.InvCDF(0, 1, 1 - prob4); // Para P(X > 7)

            // miu y sigma
            double desv = (12 - 7) / (valZ3 - valZ4);
            double media = 12 - desv * valZ3;

            // x, y
            double valorX = media + valZ1 * desv;
            double valorY = media + valZ2 * desv;

            // 8 < P < 10
            double valZ5 = (8 - media) / desv;
            double valZ6 = (10 - media) / desv;
            double proporcion = Normal.CDF(0, 1, valZ6) - Normal.CDF(0, 1, valZ5);

            // Resultados
            Console.WriteLine("a)");
            Console.WriteLine("   miu: " + media);
            Console.WriteLine("");
            Console.WriteLine("   sigma: " + desv);
            Console.WriteLine("");
            Console.WriteLine("b)");
            Console.WriteLine("   Proporción de individuos con anchura entre 8 y 10 milímetros: " + proporcion + "%");
            Console.WriteLine("");
            Console.WriteLine("c)");
            Console.WriteLine("   X: " + valorX);
            Console.WriteLine("");
            Console.WriteLine("   Y: " + valorY);
            Console.WriteLine("");
        }
    }
}
