using System;
using System.Linq;

namespace KISS_Principle
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese los precios de los platos (separados por comas): ");
            var precios = Console.ReadLine().Split(',').Select(decimal.Parse).ToList();
            
            Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
            bool propinaPersonalizada = Console.ReadLine().Trim().ToLower() == "s";
            
            decimal propina = propinaPersonalizada ? ObtenerPropina() : 0.10m;
            decimal total = precios.Sum() * (1 + propina);
            
            Console.WriteLine($"Total a pagar (con propina del {propina * 100}%): {total}");
        }
        
        static decimal ObtenerPropina()
        {
            Console.Write("Ingrese el porcentaje de propina (ejemplo: 0.15 para 15%): ");
            return decimal.Parse(Console.ReadLine());
        }
    }
}