using System;

namespace ConsoleAppEjercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduccion del programa
            Console.WriteLine("Se desea determinar la hipotenusa de un triangulo rectangulo");
            Console.WriteLine("introduzca los valores");

            //definicion de las variables y los valores a calcular
            Console.Write("Cateto A: ");
            var catetoA = int.Parse(Console.ReadLine());
            Console.Write("Cateto B: ");
            var catetoB = int.Parse(Console.ReadLine());
            double hipotenusa;
            hipotenusa = Math.Sqrt((Math.Pow(catetoA, 2)) + (Math.Pow(catetoB, 2)));
            Console.WriteLine($"El triangulo rectangulo con el Cateto A:{catetoA} cms y con el Cateto B:{catetoB} cms.");
            Console.WriteLine($"Su hipotenusa mide:{hipotenusa} cms.");
        }
    }
}
