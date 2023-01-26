using System;

namespace ConsoleAppEjercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa a desarrollar
            Console.WriteLine("Se calculara la distancia recorrida por un movil");
            Console.WriteLine("introduzca los valores a calcular");
            
            //definicion de las variables
            Console.Write("velocidad m/s: ");
            var velocidad = int.Parse(Console.ReadLine());
            Console.Write("tiempo seg.: ");
            var tiempo = int.Parse(Console.ReadLine());
            int distancia;
            
            //proceso
            distancia = tiempo * velocidad;

            //muestra de la informacion
            Console.WriteLine($"El objeto con velocidad {velocidad} m/s, recorrió {distancia} mts, a lo largo de {tiempo} seg.");

        }
    }
}
