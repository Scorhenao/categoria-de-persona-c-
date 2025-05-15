using System;

namespace ProgramaCategorias
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal SMLV = 1300000m; // Salario Mínimo Legal Vigente en Colombia para 2025 (ajústalo si cambia)
            Console.Write("Ingrese la edad de la persona: ");

            if (!int.TryParse(Console.ReadLine(), out int edad) || edad < 0)
            {
                Console.WriteLine("Edad inválida.");
                return;
            }

            string categoria = "";
            decimal subsidio = 0;

            if (edad >= 0 && edad <= 5)
            {
                categoria = "Infante";
                subsidio = SMLV * 0.12m;
                Console.WriteLine($"Categoría: {categoria}");
                Console.WriteLine($"Subsidio: ${subsidio:N0}");
                Console.WriteLine("Este infante está en el programa de bebés sanos.");
            }
            else if (edad >= 6 && edad <= 10)
            {
                categoria = "Niño";
                subsidio = SMLV * 0.10m;
                Console.WriteLine($"Categoría: {categoria}");
                Console.WriteLine($"Subsidio: ${subsidio:N0}");
                Console.WriteLine("Este niño está en el programa de niños canguro.");
            }
            else if (edad >= 11 && edad <= 15)
            {
                categoria = "Preadolescente";
                subsidio = SMLV * 0.05m;
                Console.WriteLine($"Categoría: {categoria}");
                Console.WriteLine($"Subsidio: ${subsidio:N0}");
                Console.WriteLine("Este joven está en el programa de joven sano.");
            }
            else if (edad >= 16 && edad <= 18)
            {
                categoria = "Adolescente";
                Console.WriteLine($"Categoría: {categoria}");
                Console.WriteLine("No aplica subsidio.");
            }
            else if (edad >= 19 && edad <= 25)
            {
                categoria = "Pre-adulto";
                Console.WriteLine($"Categoría: {categoria}");
                Console.WriteLine("No aplica subsidio.");
            }
            else if (edad >= 26 && edad <= 40)
            {
                categoria = "Adulto";
                Console.WriteLine($"Categoría: {categoria}");
                Console.WriteLine("No aplica subsidio.");
            }
            else if (edad >= 41 && edad <= 55)
            {
                categoria = "Pre-anciano";
                Console.WriteLine($"Categoría: {categoria}");
                Console.WriteLine("No aplica subsidio.");
            }
            else if (edad >= 56)
            {
                categoria = "Anciano";
                Console.WriteLine($"Categoría: {categoria}");
                Console.Write("Ingrese el porcentaje de IPC para este mes (ej. 12.5): ");
                if (decimal.TryParse(Console.ReadLine(), out decimal ipc))
                {
                    subsidio = SMLV * (ipc / 100);
                    Console.WriteLine($"Subsidio: ${subsidio:N0}");
                    Console.WriteLine("ALERTA: Este anciano está en el programa de adulto mayor.");
                }
                else
                {
                    Console.WriteLine("IPC inválido. No se puede calcular subsidio.");
                }
            }
            else
            {
                Console.WriteLine("Edad fuera de rango válido.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
