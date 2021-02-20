using System;

namespace Evidencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string lugar;
            int tBello, tSabaneta, tsanjavier, total, totro;

            tBello = 0;
            tsanjavier = 0;
            tSabaneta = 0;
            totro = 0;

            



            Console.WriteLine("Ingrese el número que corresponde a la estación donde está ingresando, 1 si es Bello, 2 si es Sabaneta, 3 si es San Javier, 4 otro y * para terminar el proceso: ");
            lugar = Console.ReadLine();

            while(lugar != "*")
            {
                switch (lugar)
                {
                    case "1":
                        tBello = tBello + 1;
                        
                        break;

                    case "2":
                        tSabaneta = tSabaneta + 1;
                       
                        break;

                    case "3":

                        tsanjavier = tsanjavier + 1;
                        
                        break;

                    default:
                        totro = totro + 1;
                        
                        break;
                }

                Console.WriteLine("Ingrese el número que corresponde a la estación donde está ingresando, 1 si es Bello, 2 si es Sabaneta, 3 si es San Javier, 4 otro y * para terminar el proceso: ");
                lugar = Console.ReadLine();

               

            }

            total = tBello + tsanjavier + tSabaneta + totro;


            Console.WriteLine("El total de pasajero de Bello es: " + tBello);
            Console.WriteLine("El total de pasajero de Sabaneta es: " + tSabaneta);
            Console.WriteLine("El total de pasajero de San Javier es: " + tsanjavier);
            Console.WriteLine("El total de pasajero en otras estaciones es: " + totro);
            Console.WriteLine();
            Console.WriteLine("El total de pasajero que ingresaron al metro es: " + total);

            Console.ReadKey();

        }
    }
}
