using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // Leer todas las líneas del archivo CSV
        string[] lineas = File.ReadAllLines("estudiantes.csv");

        List<Estudiante> estudiantes = new List<Estudiante>();

        // Omitir la primera línea (encabezado), empezando en el índice 1
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] datos = lineas[i].Split(',');

            Estudiante e = new Estudiante();
            e.Id = int.Parse(datos[0]);
            e.Nombre = datos[1];
            e.Carrera = datos[2];

            estudiantes.Add(e);
        }

        // Mostrar en consola
        foreach (Estudiante e in estudiantes)
        {
            Console.WriteLine($"{e.Id} - {e.Nombre} - {e.Carrera}");
        }

        // Convertir la lista a JSON
        string json = JsonSerializer.Serialize(estudiantes, new JsonSerializerOptions { WriteIndented = true });

        // Guardar el JSON en un archivo
        File.WriteAllText("estudiantes.json", json);

        Console.WriteLine("Archivo estudiantes.json creado correctamente.");
    }
}