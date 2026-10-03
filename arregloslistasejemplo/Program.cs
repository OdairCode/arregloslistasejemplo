using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arregloslistasejemplos
{
    internal class Program
    {

        static readonly int N = 3;
        static string[] estudiante = new string[N];
        static int[] nota = new int[N];


        static void IngresarEstudiantes()
        {
            for (int i = 0; i < estudiante.Length; i++)
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                estudiante[i] = Console.ReadLine();
                Console.Write("Ingrese la nota del estudiante: ");
                nota[i] = int.Parse(Console.ReadLine());
            }
        }


        static void mostrarEstudiantes()
        {
            Boolean Encontrado = false;
            Console.WriteLine("Digite un Estudiante");
            string nomb = Console.ReadLine();
            for (int i = 0; i < estudiante.Length; i++)
            {
                if (estudiante[i] == nomb)
                {
                    Console.WriteLine($"El estudiante {estudiante[i]} tiene una nota de {nota[i]}");
                    Encontrado = true;
                    break;
                }

            }
            if (Encontrado == false)
            {
                Console.WriteLine("Estudiante no encontrado");
            }
        }

        static void modificarEstudiantes()
        {
            Boolean Encontrado = false;
            Console.WriteLine("Digite un Estudiante");
            string nomb = Console.ReadLine();
            for (int i = 0; i < estudiante.Length; i++)
            {
                if (estudiante[i] == nomb)
                {
                    Console.WriteLine($"El estudiante {estudiante[i]} tiene una nota de {nota[i]}");
                    Console.WriteLine("Digite el nuevo nombre");
                    estudiante[i] = Console.ReadLine();
                    Console.WriteLine("Digite la nueva nota:");
                    nota[i] = int.Parse(Console.ReadLine());
                    Encontrado = true;
                    break;
                }

            }
            if (Encontrado == false)
            {
                Console.WriteLine("Estudiante no encontrado");
            }
        }

        static void reporteEstudiantes()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------ Reporte de Estudiantes -------");
            Console.WriteLine(" Nombre                 Nota");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < estudiante.Length; i++)
            {
                Console.WriteLine($" {estudiante[i]}        {nota[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------  ultima linea --------");
            Console.ForegroundColor = ConsoleColor.White;
        }


        static void menu()
        {
            int opcion = 0;

            do
            {

                Console.WriteLine("1. Ingresar Estudiantes");
                Console.WriteLine("2. Mostrar Estudiantes");
                Console.WriteLine("3. Modificar Estudiantes");
                Console.WriteLine("4. Eliminar Estudiantes");
                Console.WriteLine("5- Reporte");
                Console.WriteLine("6. Salir");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                switch (opcion)
                {
                    case 1:
                        IngresarEstudiantes();
                        break;
                    case 2:
                        mostrarEstudiantes();
                        break;
                    case 3:
                        modificarEstudiantes();
                        break;
                    case 4:
                        //eliminarEstudiantes();
                        break;
                    case 5:
                        reporteEstudiantes();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion != 6);

        }

        static void Main(string[] args)
        {

            menu();


        }
        //Que se hizo en todo:
        //Se creo un programa que permite ingresar estudiantes y sus notas,
        //mostrar estudiantes, modificar estudiantes, eliminar estudiantes y generar un reporte de estudiantes.

        //se utilizo arreglos para almacenar los estudiantes y sus notas, se utilizo un menu para seleccionar las opciones,
        //se utilizo un ciclo do while para mostrar el menu hasta que el usuario decida salir, se utilizo un switch para seleccionar
        //la opcion del menu, se utilizo un booleano para verificar si el estudiante fue encontrado o no, se utilizo un for para recorrer
        //los arreglos de estudiantes y notas.

        //En resumen , se creo un programa que permite gestionar estudiantes y sus notas utilizando arreglos y un menu de opciones.
    }
}