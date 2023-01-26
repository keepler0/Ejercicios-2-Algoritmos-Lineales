using System;

namespace ConsoleAppEjercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            //encabezado del programa
            Console.WriteLine("Se calculará la distancia entre dos puntos");
            Console.WriteLine("Ingrese los valores");
            
            //definicion de las varibles
            //definicion de los valores
            double distancia;
            Console.Write("x1: ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            var y2 = double.Parse(Console.ReadLine());
            //proceso del programa la cual de el resultado
            if (((Math.Pow(x2 - x1),2) + (Math.Pow(y2 - y1),2)) > 0)
            {
                //muestra del resultado final
                distancia = (Math.Sqrt(Math.Pow(x2 - x1), 2) + (Math.Pow(y2 - y1), 2));
                Console.WriteLine($"Los puntos P1({x1},{y1}) y P2 ({x2},{y2}) tiene una distancia de {distancia}");
            }
            else
            {
                //exepcion del resultado muestra el siguiente mensaje
                Console.WriteLine("Los valores asignados dan un numero negativo por lo tanto no se puede operar con raiz");
            }
        }
    }
}
