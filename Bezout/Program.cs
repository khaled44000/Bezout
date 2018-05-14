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
                Tuple<long, long, long>  bezout = calculeBezout(nombrea, nombreb);
                Console.WriteLine("PGCD : " + bezout.Item1 + "\n");
                Console.WriteLine("U : " + bezout.Item2 + "\n");
                Console.WriteLine("V : " + bezout.Item3 + "\n");

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

        private static Tuple<long, long, long> calculeBezout(long a, long b )
        {
            long r = a;
            long r1 = b;
            long u = 1;
            long v = 0;
            long u1 = 0;
            long v1 = 1;
           while (calculerReste(r, r1).Item2 > 0) // resultat
            {
               // Console.WriteLine("R1 : " + r1 + "\n");
                long q = calculerReste(r, r1).Item2;
                long rs = r;
                long us = u;
                long vs = v;
                r = r1;
                u = u1;
                v = v1;
                r1 = rs - q * r1;
                u1 = us - q * u1;
                v1 = vs - q * v1;
            }

            Tuple<long, long, long> s = Tuple.Create(r, u, v);
            
            return s;
            
        }

    }
}
