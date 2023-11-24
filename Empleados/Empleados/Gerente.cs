using System;

// Definición de la clase Gerente que hereda de Empleado
public class Gerente : Empleado, IMostrarInformacion
{
    // Nuevo atributo para el departamento que supervisa
    public string Departamento { get; set; }

    // Constructor
    public Gerente(string nombre, double salario, string departamento)
        : base(nombre, salario)
    {
        Departamento = departamento;
    }

    // Implementación de la interfaz
    void IMostrarInformacion.MostrarInformacion()
    {
        // Llamada al método de la clase base
        base.MostrarInformacion();
        Console.WriteLine($"Departamento: {Departamento}");
    }
}
