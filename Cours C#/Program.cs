#region Functions
// Functions (locales) en C#;

// static void Fonction(){};
//        <type de retour> <nom de la fonction><parametre><instructions>

// pour appeler une fonction on utilise cette syntaxe;
// Fonction(<arguments>){   };
// le resulatat d'une fonction renvoi un : Le retour.

void Bienvenue()
{
    Console.WriteLine("Hello World");
};

Bienvenue();

// la signature d'une fonction : son nom, ses paramètres et son type de retour

void BienvenueBis(String prenom = "Alex")
{
    Console.WriteLine($"Bonjour, {prenom} !");
};

BienvenueBis("Lucas");

// une fonction peut renvoyer une valeur: elle effectue un "return"

int Addition(int a, int b)
{ 
    return a + b;
}

Console.WriteLine(Addition(3, 5));

#endregion

#region classes

// un objet est l'instance d'une classe. C&d un élément qui possède
// les caracteristiques et les comportements définis par la classe.
// ex : Une Tesla rouge

// Une Classe: un modèle qui décrit les caractérisque et
// les comportments communs d'un ensemble d'objets
// Ex: Voiture

// Méthode : fonction associée à une classe ou à un objet qui défini un comportement spécifique
// Accelerer();

// Propriété: attribut associé à un objet ou une classe qui définit un caractéristique spécifique
// Ex: Couleur

// Une classe est un type de donnée                 - Un objet est une instance de classe
// Génère des objets                                - Donne vie à une classe
// N'occupe pas d'espaces en mémoire                - Occupe de l'espace mémoire
// Ne peut pas être manipulé (sauf static)          - Peut être manipulé


// La class Program est une classe particulière car elle contient la méthode "MAIN()" c'est le point d'entrée de notre application

// les classes s'écrivent en PascalCase !

#endregion