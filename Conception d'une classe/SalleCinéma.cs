using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception_d_une_classe
{
    class SalleCinema
    {
        string _film;
        int _nombreSiege, _venduTarifNormal, _venduTarifReduit, _nbsalle;
        double _tarifNormal;

        public SalleCinema(string film, int nombreSiege, double tarifNormal)
        {
            _film = film;
            _nombreSiege = nombreSiege;
            _venduTarifNormal = 0;
            _venduTarifReduit = 0;
            _tarifNormal = tarifNormal;
            _nbsalle = 0;
        }
        public int getSalle()
        {
            return _nbsalle;
        }
        public string getFilm()
        {
            return _film;
        }
        public int getNombreSiege()
        {
            return _nombreSiege;
        }

        public int getVenduTarifNormal()
        {
            return _venduTarifNormal;
        }

        public int getVenduTarifReduit()
        {
            return _venduTarifReduit;
        }
        public double getTarifNormal()
        {
            return _tarifNormal;
        }

        public void setTarifNormal(double tarifNormal)
        {
            _tarifNormal = tarifNormal;
        }

        public void Afficher()
        {
            Console.WriteLine("Film joué : " + _film);
            Console.WriteLine("Nombre de places : " + _nombreSiege);
            Console.WriteLine("Prix d'une place : " + _tarifNormal);
            Console.WriteLine(_venduTarifNormal + " places vendues au tarif normal");
            Console.WriteLine(_venduTarifReduit + " places vendues au tarif réduit");
            Console.WriteLine("--------------------------------");
        }

        public int nbPlacesDisponibles()
        {
            int nombrePlaceDispo;
            nombrePlaceDispo = _nombreSiege - (_venduTarifNormal + _venduTarifReduit);
            Console.WriteLine("Il y a " + nombrePlaceDispo + " places disponibles");
            Console.WriteLine("--------------------------------");
            return nombrePlaceDispo;
        }

        public void vendrePlaces(int nbre, bool tarifReduit)
        {
            double PrixReduction, Prix;

            if (nbre > _nombreSiege)
            {
                Console.WriteLine("Nombre de place disponible insuffisante, la vente n'est pas possible");
            }
            else
            {
                if (tarifReduit == true)
                {
                    PrixReduction = _tarifNormal * 0.8;
                    PrixReduction = PrixReduction * nbre;
                    _venduTarifReduit = nbre;
                    Console.WriteLine("Le prix de vos places sont donc de : " + PrixReduction + " euros");
                    Console.WriteLine("--------------------------------");
                }
                else
                {
                    Prix = _tarifNormal * nbre;
                    _venduTarifNormal = nbre;
                    Console.WriteLine("Le prix de vos places sont donc de : " + Prix + " euros");
                    Console.WriteLine("--------------------------------");
                }
            }
        }

        public void remiseAZero(bool SeanceFini)
        {
            if (SeanceFini == true)
            {
                _venduTarifNormal = 0;
                _venduTarifReduit = 0;
                Console.WriteLine("Les compteurs ont été remis à 0");
                Console.WriteLine("--------------------------------");
            }
            else
            {
                Console.WriteLine("Veillez attendre la fin de la séance");
                Console.WriteLine("--------------------------------");
            }
        }

        public double chiffreAffaires()
        {
            double affaire;

            affaire = (_venduTarifNormal * _tarifNormal) + _venduTarifReduit * (0.8 * _tarifNormal);

            return affaire;
        }

        public double tauxRemplissage()
        {
            double taux;

            taux = 100 * (_venduTarifReduit + _venduTarifNormal) / _nombreSiege;
            return taux;
        }
        public double compare()
        {
            double salle, affaire;

            salle = affaire = tauxRemplissage();
            return salle;
        }
        public static int Salle()
        {
            int nb;
            nb = 0;
            nb = nb + 1;
            return nb;
        }
    }
}
