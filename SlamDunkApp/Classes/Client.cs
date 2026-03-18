using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlamDunkApp
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string? Entreprise { get; set; } // Peut être null dans la BDD
        public string Email { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;

        public string Statut { get; set; } // Peut contenir "Prospect" ou "Client"

        // Propriété magique pour l'affichage dans la ComboBox
        // Propriété magique pour l'affichage dans les listes
        public string NomComplet
        {
            get
            {
                // Si c'est un prospect on met la cible, sinon on met le bonhomme
                string prefix = Statut == "Prospect" ? "🎯 [PROSPECT]" : "👤 [CLIENT]";

                string ste = string.IsNullOrEmpty(Entreprise) ? "" : $" ({Entreprise})";
                return $"{prefix} {Nom.ToUpper()} {Prenom}{ste}";
            }
        }
    }
}