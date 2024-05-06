using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace Simulación_U3
{
    internal class EJ612
    {
        static void Main()
        {
            int tamañoMuestra = 20;
            double probabilidad = 0.4;

            // Media y desviación estándar 
            double media = tamañoMuestra * probabilidad;
            double desviacionEstandar = Math.Sqrt(tamañoMuestra * probabilidad * (1 - probabilidad));


            double correccionContinuidad = 11.5;  // Corrección de continuidad


            double z = (correccionContinuidad - media) / desviacionEstandar; // Z


            double probabilidadAcumulativa = Normal.CDF(0, 1, z); // Distribución normal acumulativa


            double resultado = 1 - probabilidadAcumulativa; // P (X >= 12)

            Console.WriteLine("Probabilidad de que 12 ó más niños afectados tengan madres que fumaban: {0}", resultado.ToString("0.0000"));
        }
    }
}
