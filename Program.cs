using System;
using System.Collections.Generic;

class Task
{
    public string Description { get; set; }
    public bool Completed { get; set; }
}

class Program
{
    static List<Task> tasks = new List<Task>(); // Corregir aquí

    static void Main()
    {
        Console.WriteLine("**********************************************");
        Console.WriteLine("*          Trabajo de Inacap - Francisco     *");
        Console.WriteLine("*           Bienvenido al Listado de Tareas  *");
        Console.WriteLine("**********************************************");

        while (true)
        {
            ShowTasks();
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Marcar tarea como completada");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Elija una opción: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    MarkTaskAsCompleted();
                    break;
                case "3":
                    DeleteTask();
                    break;
                case "4":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void ShowTasks()
    {
        Console.WriteLine("\nLista de Tareas:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. [{(tasks[i].Completed ? "X" : " ")}] {tasks[i].Description}");
        }
    }

    static void AddTask()
    {
        Console.Write("Ingrese la descripción de la tarea: ");
        string description = Console.ReadLine();
        tasks.Add(new Task { Description = description, Completed = false });
        Console.WriteLine("Tarea agregada.");
    }

    static void MarkTaskAsCompleted()
    {
        Console.Write("Ingrese el número de la tarea que desea marcar como completada: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0 && number <= tasks.Count)
        {
            tasks[number - 1].Completed = true;
            Console.WriteLine("Tarea marcada como completada.");
        }
        else
        {
            Console.WriteLine("Número de tarea no válido.");
        }
    }

    static void DeleteTask()
    {
        Console.Write("Ingrese el número de la tarea que desea eliminar: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0 && number <= tasks.Count)
        {
            tasks.RemoveAt(number - 1);
            Console.WriteLine("Tarea eliminada.");
        }
        else
        {
            Console.WriteLine("Número de tarea no válido.");
        }
    }
}