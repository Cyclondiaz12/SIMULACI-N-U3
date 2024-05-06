using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace Simulación_U3
{
    internal class EJ69
    {
        static void Main()
        {
            double med = 110;
            double valinf = 85;
            double valsup = 135;
            double porcint = 0.70;
            double desv = (valsup - med) / 2.575;


            // Límites del 70% de los valores
            double m = 1.036; // P(Z < k) = 0.85

            double liminf = med - desv * m;

            double limsup = med + desv * m;



            // Porcentajes 
            double porcsup135 = 1 - Normal.CDF(med, desv, valsup);

            double porcinf95 = Normal.CDF(med, desv, 95);

            double porc90125 = Normal.CDF(med, desv, 125) - Normal.CDF(med, desv, 90);

            double porc85100 = Normal.CDF(med, desv, 100) - Normal.CDF(med, desv, 85);


            Console.WriteLine("Desviación estándar: " + desv);
            Console.WriteLine("" );
            Console.WriteLine("Intervalo del 70% de los valores: [" + liminf + ", " + limsup + "]");
            Console.WriteLine("");
            Console.WriteLine("a) Población con más de 135 microgramos por mililitro: " + porcsup135 * 100 + "%");
            Console.WriteLine("");
            Console.WriteLine("b) Población con menos de 9 microgramos por mililitro: " + porcinf95 * 100 + "%");
            Console.WriteLine("");
            Console.WriteLine("c) Población con entre 90 y 125 microgramos por mililitro: " + porc90125 * 100 + "%");
            Console.WriteLine("" );
            Console.WriteLine("d) Población con entre 85 y 100 microgramos por mililitro: " + porc85100 * 100 + "%");
        }
    }
}
