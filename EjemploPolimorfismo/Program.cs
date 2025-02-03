using System;

abstract class Empleado
{
    public string Nombre { get; set; }
    public bool MetaAlcanzada { get; set; }

    public Empleado(string nombre, bool metaAlcanzada)
    {
        Nombre = nombre;
        MetaAlcanzada = metaAlcanzada;
    }

    public abstract decimal CalcularSalario();
}

class DocentePorHora : Empleado
{
    public int HorasTrabajadas { get; set; }
    private const decimal TarifaPorHora = 800;

    public DocentePorHora(string nombre, int horasTrabajadas, bool metaAlcanzada)
        : base(nombre, metaAlcanzada)
    {
        HorasTrabajadas = horasTrabajadas;
    }

    public override decimal CalcularSalario()
    {
        return HorasTrabajadas * TarifaPorHora;
    }
}

class DocenteFijo : Empleado
{
    public decimal SalarioBase { get; set; }

    public DocenteFijo(string nombre, decimal salarioBase, bool metaAlcanzada)
        : base(nombre, metaAlcanzada)
    {
        SalarioBase = salarioBase;
    }

    public override decimal CalcularSalario()
    {
        return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
    }
}
class EmpleadoAdministrativo : Empleado
{
    public decimal SalarioBase { get; set; }

    public EmpleadoAdministrativo(string nombre, decimal salarioBase, bool metaAlcanzada)
        : base(nombre, metaAlcanzada)
    {
        SalarioBase = salarioBase;
    }

    public override decimal CalcularSalario()
    {
        return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Empleado docentePorHora = new DocentePorHora("Cielo", 40, false);
        Empleado docenteFijo = new DocenteFijo("Luz", 50000, true);
        Empleado administrativo = new EmpleadoAdministrativo("Sol", 40000, false);

        Console.WriteLine($"{docentePorHora.Nombre} - Salario Mensual: {docentePorHora.CalcularSalario():C}");
        Console.WriteLine($"{docenteFijo.Nombre} - Salario Mensual: {docenteFijo.CalcularSalario():C}");
        Console.WriteLine($"{administrativo.Nombre} - Salario Mensual: {administrativo.CalcularSalario():C}");
    }
}
