using System;

namespace ConsoleAppEjercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            //definicion de las variables
            int jugados, ganados, perdidos, goles, golesContra;
            int empatados, puntos, difGol;
            double promedio;
            jugados = 20;
            Console.WriteLine("Se calculara los resultados de un equipo de futbol en la temporada");
            Console.WriteLine("escriba los:");
            Console.Write("partidos ganados: ");
            ganados = int.Parse(Console.ReadLine());
            Console.Write("partidos perdidos: ");
            perdidos = int.Parse(Console.ReadLine());
            if (ganados + perdidos <= 20 || perdidos - ganados >= 20)
            {
                empatados = jugados - ganados - perdidos;
                Console.WriteLine($"El equipo tiene {ganados} partidos ganados, {empatados} empatados y {perdidos} perdidos");
                puntos = (empatados * 1) + (ganados * 3);
                Console.WriteLine($"El equipo obtuvo {puntos} puntos en la temporada.");
                Console.Write("Goles: ");
                goles = int.Parse(Console.ReadLine());
                Console.Write("goles recibidos: ");
                golesContra = int.Parse(Console.ReadLine());
                promedio = goles / jugados;
                Console.WriteLine($"El promedio de goles del equipo es:{promedio} ");
                difGol = goles - golesContra;
                Console.WriteLine($"El equipo obtuvo una diferencia de goles de:{difGol} ");
            }
                else
            {
                Console.WriteLine("el valor ingresado supera los partidos jugados");
            }
            
        }
    }
}
