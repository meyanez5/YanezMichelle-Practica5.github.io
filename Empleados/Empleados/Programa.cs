using System;

class Program
{
    static void Main()
    {
        // Crear instancias de Empleado y Gerente
        Empleado empleado = new Empleado("Michelle", 1000);
        Gerente gerente = new Gerente("Wendy", 1500, "Marketing");

        // Mostrar información utilizando polimorfismo a través de la interfaz
        MostrarInformacion(empleado);
        Console.WriteLine();
        MostrarInformacion((IMostrarInformacion)gerente);
    }

    // Método para mostrar información a través de la interfaz
    static void MostrarInformacion(IMostrarInformacion entidad)
    {
        entidad.MostrarInformacion();
    }
}
