using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            char debut = '1'; //Indique la position de début (à la sortie).
            char fin = '2'; //Indique la position de fin (à la sortie).
            char temporaire = '3'; //Indique la position temporaire (à la sortie).
            int nbTotalDisques = 3; //Nombre total de disques

            resoudreJeuHanoi(nbTotalDisques, debut, fin, temporaire);

            Console.ReadLine();
        }

        private static void resoudreJeuHanoi(int nbDisques, char debut, char fin, char temp)
        {
            if (nbDisques > 0)
            {
                resoudreJeuHanoi(nbDisques - 1, debut, temp, fin);
                Console.WriteLine("On bouge le disque " + debut + " vers " + fin);
                resoudreJeuHanoi(nbDisques - 1, temp, fin, debut);
            }
        }
    }
}
