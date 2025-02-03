using System;
using System.Linq;

namespace DRY_Principle
{
    class Program
    {
        static void Main()
        {
            Console.Write("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo): ");
            int tipo = int.Parse(Console.ReadLine());
            decimal salarioBruto = tipo == 1 ? ObtenerSalarioBase() : ObtenerSalarioPorHoras();
            decimal salarioNeto = CalcularSalarioNeto(salarioBruto);
            
            Console.WriteLine($"Salario neto después de impuestos y bono: {salarioNeto}");
        }
        
        static decimal ObtenerSalarioBase()
        {
            Console.Write("Ingrese el salario base: ");
            return decimal.Parse(Console.ReadLine());
        }
        
        static decimal ObtenerSalarioPorHoras()
        {
            Console.Write("Ingrese el sueldo por hora: ");
            decimal sueldoHora = decimal.Parse(Console.ReadLine());
            Console.Write("Ingrese las horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine());
            return sueldoHora * horas;
        }
        
        static decimal CalcularSalarioNeto(decimal salario)
        {
            return salario * 0.87m;
        }
    }
}