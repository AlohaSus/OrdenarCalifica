using System;
using System.Linq;
using System.Collections.Generic;
namespace OrdenCalificaciones
{
    class Program
    {
        static int[] calif = new int[]
        {
            80,30,40,45,68,78,98,36,52,41,25,36,75,86,9,8,14,39
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Calificaciones");

            for (int n = 0; n < calif.Length; n++)
            {
                for (int j = 0; j < calif.Length - 1; j++)
                {
                    if (calif[j] > calif[j + 1])
                    {
                        int a = calif[j];
                        calif[j] = calif[j + 1];
                        calif[j + 1] = a;
                    }
                    
                }

            }
            Ver();

            //reprobados, aprobados y excelencia
            int aprobados = 0;
            foreach (var ap in calif)
            {
                if (ap > 75)
                {
                    aprobados += 1;
                }
            }
            Console.WriteLine("Aprobados: " + aprobados);
            int reprobados = 0;
            foreach (var rep in calif)
            {
                if (rep <= 75)
                {
                    reprobados += 1;
                }
            }
            Console.WriteLine("Reprobados: " + reprobados);

            int excelencia = 0;
            foreach (var ex in calif)
            {
                if (ex >= 95)
                {
                    excelencia += 1;
                }
            }

            Console.WriteLine("Beca Excelencia: " + excelencia);

            var promedio = calif.Average();
            Console.WriteLine("Promedio General: " + promedio);
            

            
            

        }
        public static void Ver()
        {
            foreach (var cal in calif)
            {
                Console.Write(cal + ",");
            }
            Console.WriteLine("\n");
        }

        
    }




    
    
}
