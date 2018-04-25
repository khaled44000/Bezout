using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezout
{
    class Program
    {
        
        static void Main(string[] args)
        {

            long nombrea = 0; //On initialise les variables à 0
            long nombreb = 0;
            long reste = 1;     // La boucle ne s'activera pas si le reste est déjà égale à 0
            long reste2 = 1;
            long quotient = 0;
            long PGCD = 0;
            long resultat = 0;
            bool isAValide = false;
            bool isBValide = false;
            while (!isAValide)
            {
                Console.WriteLine("Tout d'abord le premier nombre (Entier positif seulement)\n");
                nombrea = Convert.ToInt64(Console.ReadLine());
                isAValide = (nombrea > 0);
            }
            while (!isBValide) {
                Console.WriteLine("Et le deuxieme nombre (Entier positif seulement)\n");
                nombreb = Convert.ToInt64(Console.ReadLine());
                isBValide = (nombreb > 0);
            }

            if (nombrea > nombreb)
            {
                Tuple<long, long> calculer = calculerReste(nombrea, nombreb);
                resultat = calculer.Item2;
                reste = calculer.Item1;
                Console.WriteLine("Le résulat : " + resultat + "\n");
                Console.WriteLine("Le Reste : " + reste + "\n");

            }
            else
            {

            }

            Console.ReadKey();
        }

        private static Tuple<long , long> calculerReste(long NbreA, long NbreB)
        {
            int resultat1 = 0;
            Tuple<long, long> returnedValue = new Tuple<long, long>(0,0);
            while( NbreA > NbreB)
            {
                NbreA -= NbreB;
                resultat1 +=1;
            }
            returnedValue = new Tuple<long, long>(NbreA, resultat1);
            return returnedValue;
        }
    }
}
