using System;

namespace ConsoleAppEjercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //encabezado del programa
            Console.WriteLine("Se calculará la altura total del edificio");
            Console.WriteLine("ingrese la cantidad de los pisos y la altura de ellas.");
            
            //imput y definicion de las variables
            Console.Write("Pisos: ");
            var pisos = double.Parse(Console.ReadLine());
            Console.Write("altura: ");
            var altPiso = double.Parse(Console.ReadLine());
            double altEdificio;
            //proceso del programa
            if ((pisos > 0) && (altPiso>0))
            {
                altEdificio = pisos * altPiso;
                //muestra de la informacion y resultados
                Console.WriteLine($"El edificio con {pisos} pisos de {altPiso} mts de altura, tiene una medida total de {altEdificio} mts.");
            }
            else
            {
                Console.WriteLine("los valores asignados son incorrectos.");
            }
        }
    }
}
