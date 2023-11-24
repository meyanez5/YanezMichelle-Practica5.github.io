using System;

// Definición de la clase Empleado
public class Empleado : IMostrarInformacion
{
    // Atributos
    public string Nombre { get; set; }
    public double Salario { get; set; }

    // Constructor
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    // Método para calcular el salario anual
    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    // Implementación de la interfaz
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Salario Mensual: {Salario:C}");
        Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
    }
}
