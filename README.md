# Aplicación de Gestión de Empleados

Esta aplicación en C# es un ejemplo básico de Programación Orientada a Objetos (POO) que gestiona información de empleados y gerentes.

## Clases

### 1. `IMostrarInformacion`

- Interfaz que define el método `MostrarInformacion` para mostrar información general.

### 2. `Empleado`

- Clase que representa a un empleado con atributos como Nombre y Salario.
- Implementa la interfaz `IMostrarInformacion`.
- Contiene un constructor para inicializar los atributos y un método para calcular el salario anual.

### 3. `Gerente`

- Clase que hereda de `Empleado` y agrega un atributo para el departamento supervisado.
- Implementa la interfaz `IMostrarInformacion`.
- Contiene un constructor que utiliza el constructor de la clase base (`Empleado`) y un nuevo método para mostrar la información de un gerente.

## Programa Principal

- El programa principal (`Program.cs`) crea instancias de `Empleado` y `Gerente`.
- Utiliza el polimorfismo a través de la interfaz para mostrar la información de los empleados.

## Ejecución

Para ejecutar el programa, simplemente compila el código y ejecuta el archivo ejecutable resultante.

```bash
dotnet run

