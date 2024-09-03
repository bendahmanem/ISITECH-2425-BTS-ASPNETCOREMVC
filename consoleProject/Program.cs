using System;
using data;
using consoleProject.models;
using System.Collections.Generic;

namespace consoleProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Depuis Status.cs
        Status currentStatus = Status.PROFESSEUR;

        // Interpolation de chaîne
        Console.WriteLine($" Status:  {currentStatus}");

        Professeur prof = new Professeur("M. Dupont", "Mathematiques");
        // erreur : Console.WriteLine("Professeur: " + prof.Name + " - Matiere: " + prof.Subject);
        prof.Display();

        // On peut directement acceder a la propriete Age
        Console.WriteLine(prof.Age);


        List<int> grades = new List<int>();

        grades.Add(45);
        grades.Add(78);
        grades.Add(90);
        grades.Add(100);

        grades.ForEach(grade => Console.WriteLine(grade));


    }
}

