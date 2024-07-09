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