using System;
using System.Collections.Generic;

public abstract class Persona
{
    public string Nombre { get; set; }

    protected Persona(string nombre)
    {
        Nombre = nombre;
    }
}

public class Estudiante : Persona
{
    public int NumeroUnico { get; set; }

    public Estudiante(string nombre, int numeroUnico) : base(nombre)
    {
        NumeroUnico = numeroUnico;
    }
}

public class Profesor : Persona
{
    public List<Curso> Cursos { get; set; } = new List<Curso>();

    public Profesor(string nombre) : base(nombre) { }
}

public class Curso
{
    public string Nombre { get; set; }
    public int RecuentoClases { get; set; }
    public int RecuentoEjercicios { get; set; }

    public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
    {
        Nombre = nombre;
        RecuentoClases = recuentoClases;
        RecuentoEjercicios = recuentoEjercicios;
    }
}

public class Clase
{
    public string Identificador { get; set; }
    public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    public List<Profesor> Profesores { get; set; } = new List<Profesor>();

    public Clase(string identificador)
    {
        Identificador = identificador;
    }
}