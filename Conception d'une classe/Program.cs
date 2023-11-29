using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception_d_une_classe
{
    class Program
    {

        static void Main(string[] args)
        {
            string reduction, seance;
            int nombrePlaceDispo, nbre, nb;
            double taux, affaire, salle, salle1, salle2;
            bool tarifReduit, SeanceFini;
            SalleCinema s1 = new SalleCinema("Sacré Graal", 60, 7.5);
            s1.Afficher();
            nombrePlaceDispo = s1.nbPlacesDisponibles();
            Console.WriteLine("Combien de places souhaitez vous acheter ?");
            nbre = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Possédez vous une réduction ? (o/n)");
            reduction = Console.ReadLine();
            if (reduction == "o")
            {
                tarifReduit = true;
            }
            else
            {
                tarifReduit = false;
            }
            s1.vendrePlaces(nbre, tarifReduit);
            taux = s1.tauxRemplissage();
            Console.WriteLine("La salle est donc remplie à " + taux + "%");
            affaire = s1.chiffreAffaires();
            Console.WriteLine("Le cinéma a donc fait un chiffre d'affaire de " + affaire + " euros");
            Console.WriteLine("--------------------------------");

            SalleCinema s2 = new SalleCinema("Matrix", 40, 6.5);
            s2.Afficher();
            nombrePlaceDispo = s2.nbPlacesDisponibles();
            Console.WriteLine("Combien de places souhaitez vous acheter ?");
            nbre = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Possédez vous une réduction ? (o/n)");
            reduction = Console.ReadLine();
            if (reduction == "o")
            {
                tarifReduit = true;
            }
            else
            {
                tarifReduit = false;
            }
            s2.vendrePlaces(nbre, tarifReduit);
            taux = s2.tauxRemplissage();
            Console.WriteLine("La salle est donc remplie à " + taux + "%");
            affaire = s2.chiffreAffaires();
            Console.WriteLine("Le cinéma a donc fait un chiffre d'affaire de " + affaire + " euros");
            Console.WriteLine("--------------------------------");

            salle = s1.compare();
            salle1 = salle;
            salle = s2.compare();
            salle2 = salle;

            if (salle1 == salle2)
            {
                Console.WriteLine("0");
                Console.WriteLine("--------------------------------");
            }
            if (salle1 > salle2)
            {
                Console.WriteLine("1");
                Console.WriteLine("--------------------------------");
            }
            if (salle1 < salle2)
            {
                Console.WriteLine("-1");
                Console.WriteLine("--------------------------------");
            }
            
            nb = s2.getSalle() + s1.getSalle() + 2 ;
            Console.WriteLine("Il y à " + nb + " salles");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("La séance de la salle 1 est-elle terminée ? (o/n)");
            seance = Console.ReadLine();
            if (seance == "o")
            {
                SeanceFini = true;
            }
            else
            {
                SeanceFini = false;
            }
            s1.remiseAZero(SeanceFini);

            Console.WriteLine("La séance de la salle 2 est-elle terminée ? (o/n)");
            seance = Console.ReadLine();
            if (seance == "o")
            {
                SeanceFini = true;
            }
            else
            {
                SeanceFini = false;
            }
            s2.remiseAZero(SeanceFini);
            Console.ReadLine();
        }
    }
}
