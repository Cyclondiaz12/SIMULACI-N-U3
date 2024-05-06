using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace Simulación_U3
{
    internal class EJ610
    {
        static void Main()
        {

            double probA = 0.58; // P(X < 165) = 58%
            double probB = 0.38; // P(165 <= X < 180) = 38%

            // Límites
            double limInf = 165;
            double limSup = 180;

            // Z
            var distribucionNormal = new Normal(0, 1);

            //Inf y Sup
            double zInferior = distribucionNormal.InverseCumulativeDistribution(probA);
            double zSuperior = distribucionNormal.InverseCumulativeDistribution(probA + probB);

            // Desviación estándar y media
            double desv2 = (limSup - limInf) / (zSuperior - zInferior);
            double media2 = limInf - zInferior * desv2;

            Console.WriteLine("a) ");
            Console.WriteLine($"Media: {media2:F2}");
            Console.WriteLine(" ");
            Console.WriteLine($"Desviación típica: {desv2:F2}");
            Console.WriteLine(" ");
            Console.WriteLine("b) ");

            double limTratamiento = 183;

       
            double zTratamiento = (limTratamiento-media2) / desv2;  // Z en límite de tratamiento


            double probTratamiento = 1 - distribucionNormal.CumulativeDistribution(zTratamiento);  // Probabilidad de tratamiento

            
            int poblacionTotal = 100000; // Población

           
            int personasTratamiento = (int)(poblacionTotal * probTratamiento); //Personas que necesitan tratamiento


            // Resultados finales
            Console.WriteLine($"Probabilidad de tener un índice mayor a 183: {probTratamiento:P2}");
            Console.WriteLine(" ");
            Console.WriteLine($"Número de personas a tratar en una población de 100000 individuos: {personasTratamiento}");

        } 
    }
}
