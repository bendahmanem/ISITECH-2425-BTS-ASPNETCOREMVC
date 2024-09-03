# Dotnet CLI (Command line interface)

## petit aparté sur les commandes linux

Pour creer un fichier sur bash :

```sh
touch nomDuFichier.extension
touch readme.md
```

## dotnet new

Cette commande permet de créer un nouveau projet. Elle prend en paramètre le type de projet à créer (console, web, etc.) et le nom du projet.

Pour visualiser la liste des types de projets disponibles, vous pouvez utiliser la commande `dotnet new --list`.

Nous allons creer un projet console avec le cli dotnet :

```sh
dotnet new console -n nomDuProjet --output nomDuDossier
dotnet new console -n nomDuProjet -o nomDuDossier
```

Pour lancer le projet il faut utiliser la commande `dotnet run`.

Cette commande doit etre lancée dans un terminal à la racine du projet : **Le dossier qui contient le fichier dont l'extension est .csproj**.

Nous souhaitons creer un projet console qui n'utilise pas **de directives using implicites** et qui presente une methode `main` comme point d'entrée.

```sh
dotnet new console --use-program-main -n nomDuProjet -o nomDuDossier
```

## dotnet build

La commande `dotnet build` permet de compiler le projet. Elle génère un fichier exécutable dans le dossier `bin/Debug/net8.0/`.

```sh
dotnet build
```
