using System;

namespace consoleProject.models;

public class Professeur
{
    // declarer des attributs de portee privees
    private string _name;

    private string _subject;

    // ceci est une prop
    public int Age { get; private set; }


    // puis les initialiser dans le constructeur
    public Professeur(string name, string subject)
    {
        this._name = name;
        this._subject = subject;
        this.Age = 30;
    }
    // Ensuite dans le fichier program on peut creer une instance
    // de la classe Professeur

    // On va creer une methode qui permet d'afficher les informations
    public void Display()
    {
        Console.WriteLine($"Professeur: {_name} - Matiere: {_subject}");
    }
}