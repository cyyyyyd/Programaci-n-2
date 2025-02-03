using System;
using System.Linq;

namespace YAGNI_Principle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Producto '{nombre}' agregado con éxito.");
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese el ID del producto: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine($"Producto con ID {id} eliminado.");
            }
        }
    }
}

