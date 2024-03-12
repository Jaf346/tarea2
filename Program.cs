using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
           
            while (continuar == 's' || continuar == 'S')
            {
                Console.WriteLine("Ingrese número de cédula del empleado:");
                string cedula = Console.ReadLine();

                Console.WriteLine("Ingrese nombre del empleado:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese tipo de empleado (1-Operario, 2-Técnico, 3-Profesional):");
                int tipoEmpleado = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese precio por hora:");
                double precioHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de horas laboradas:");
                double horasLaboradas = double.Parse(Console.ReadLine());

                double salarioOrdinario = precioHora * horasLaboradas;
                double aumento = 0;

                switch (tipoEmpleado)
                {
                    case 1:
                        aumento = salarioOrdinario * 0.15;
                        break;
                    case 2:
                        aumento = salarioOrdinario * 0.10;
                        break;
                    case 3:
                        aumento = salarioOrdinario * 0.05;
                        break;
                    default:
                        Console.WriteLine("Tipo de empleado inválido.");
                        break;
                }

                double salarioBruto = salarioOrdinario + aumento;
                double deduccionCCSS = salarioBruto * 0.0917;
                double salarioNeto = salarioBruto - deduccionCCSS;

                Console.WriteLine("\n-- Información del empleado --");
                Console.WriteLine("Cédula: " + cedula);
                Console.WriteLine("Nombre Empleado: " + nombre);
                Console.WriteLine("Tipo Empleado: " + tipoEmpleado);
                Console.WriteLine("Salario por Hora: " + precioHora);
                Console.WriteLine("Cantidad de Horas: " + horasLaboradas);
                Console.WriteLine("Salario Ordinario: " + salarioOrdinario);
                Console.WriteLine("Aumento: " + aumento);
                Console.WriteLine("Salario Bruto: " + salarioBruto);
                Console.WriteLine("Deducción CCSS: " + deduccionCCSS);
                Console.WriteLine("Salario Neto: " + salarioNeto);

                Console.WriteLine("\n¿Desea calcular el salario de otro empleado? (s/n):");
                continuar = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
            }

        }
    }
}
