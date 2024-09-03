# Rappels de C#

## Espaces de noms, directives et global using

### Espaces de noms (namespace)

La premiere brique de constructuion des applications C# est l'espace de noms. Il permet de regrouper des classes, des interfaces, des structures, des énumérations et d'autres espaces de noms.
Les namespaces sont des contenants logiques de code.

```csharp
namespace HelloWorld
{
    // ajoutez votre code ici
}
```

Depuis C# 10, on peut aussi ecrire:

```csharp
namespace HelloWorld;
```

### Directives (using)

Les espaces de nom sont un bon moyen de séparer/isoler les bouts de code, surtout lorsqu'un projet prend de l'ampleur.

Pour utiliser du code provenant d'un autre namespace vous avez deux options:

- utiliser la directive using pour importer le namespace complet
- utiliser le nom complet de la classe

```csharp
using System;

// ou le nom complet de la classe:
System.Console.WriteLine("Hello World!");
```

## Variables et types de données

Pour declarer une variable en C#:

```csharp
int myInt = 42;

var myVar = 42;
```

Lorsqu'on utilise le mot cle 'var', le compilateur infere le type de la variable.

Voici quelques types courants en C#:

- `int` : entier signé 32 bits: -2,147,483,648 to 2,147,483,647
- `long` : entier signé 64 bits: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
- `float` : nombre à virgule flottante 32 bits: -3.402823e38 to 3.402823e38
- `double` : nombre à virgule flottante 64 bits: -1.79769313486232e308 to 1.79769313486232e308
- `decimal` : nombre à virgule flottante 128 bits: (-7.9 x 10^28 to 7.9 x 10^28) / (10^(0 to 28))
- `bool` : valeur booléenne: true or false
- `string` : chaine de caractères
- `char` : caractère Unicode 16 bits
- `object` : type de base pour tous les types
- `DateTime` : type pour les dates et heures

## Enumerations

En C# on a deux methodes principales pour creer des types de données : les classes et les enumerations.

voici la syntaxe pour creer une enumeration:

```csharp
enum Status { INSTRUCTEUR, ASSISTANT, ETUDIANT, PROFESSEUR }
```

## Classes

Il s'agit d'un autre moyen de creer des types de données en c#. Une classe est un modele pour creer des objets.

```csharp
class Professeur
{}
```

## Reference et Objet

```csharp
Professeur moiMeme; // Ceci est une reference
```

```csharp
moiMeme = new Professeur(); // Ceci est un objet ou une instance
```

Vous pouvez ecrire ceci aussi:

```csharp
var unAutreProfesseur = new Professeur();
```

Ou encore ceci (en C# 10 et plus):

```csharp
Professeur encoreUnAutreProfesseur = new();
```

Decrivez le code suivant:

```csharp
Professeur moiMeme = new Professeur();
Professeur mounir = moiMeme; // mounir et moiMeme referencent le meme objet
```

## Variables d'instances (champs non statiques)

En Csharp :

```csharp
// voici des champs d'instance / fields / attributs
class Professeur
{
    public string Nom;
    public string Prenom;
    public string Matricule;
}
```

## Proprietes

En Csharp, on utilise des proprietes pour acceder aux champs d'une classe (en general des champs prives):

- public: accessible de partout
- private: accessible uniquement dans la classe

```csharp
public class Professeur
{
    private string _nom;


    Professeur(string nom)
    {
        _nom = nom;
    }
}
```

Le constructeur de la classe est une methode qui est appelée lorsqu'on cree une instance de la classe. (cf projet)

En C# pour modifier plus facilement l'acces en lecture et en ecriture d'un champ, on utilise des proprietes:

```csharp
public int Age { get; private set;}
```

## Collections & Generics

Les collections sont des classes qui permettent de grouper et de gerer des types de donnees. Ils sont contenus au sein de l'espace de noms : `System.Collections.Generic`.

```csharp
List<int> liste = new List<int>();

List<Professeur> mesProfs = new List<Professeur>();
```
