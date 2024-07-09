using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_C_.Classes
{
    // Indicateur de visibilité public/private/protected/internal
    internal class Voiture
    {
        // Attributs :
            // Un ensemble de variables permettant de définir les caractéristiques de notre objet (variable d'instance).
            // Ils doivent être déclarés par conventon au début de note classe.
            // Tout type ( int, float, string, List<>, Voiture, Personne... )
            // norme de nomenclature: private String _model; private string _model = "Tesla";
        private string  _model;
        private string  _couleur;
        private int     _reservoir;
        private int     _autonomie;

        // Propriétés:
            // GetXXX() et SetXXX()
            // En C# l'encapsulation est simplifiée par le principe de propriétés,
            // en regroupant le Getter, et le Setter en un element de la casse.
            // { get => _model; set => _model = value }
            // Getter: définie un comportement à la récupération
            // Setter: définie un comportement spécifique à la modification
            // Getter et Setter ont une signature bloquée
            // en Java on parle de méthode getAttribut() et setAttribut(valeur)

            // public String Model { _model; }
            // public String Model { get; set; }

        public string Model { get => _model; set => _model = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }
        public int Reservoir { get => _reservoir; set => _reservoir = value; }
        public int Autonomie { get => _autonomie; set => _autonomie = value; }

        // Constructeur
            // Outil pour créer des nouvelles voitures
            // Le constructeur définit la manière de créer l'instance.

        public Voiture(string model, string couleur, int reservoir, int autonomie)
        {
            Model = model;
            Couleur = couleur;
            Reservoir = reservoir;
            Autonomie = autonomie;
        }

    }
}
