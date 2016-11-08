using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Alien
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create some Aliens
            Predator p = new Predator(100, 20);
            Alien a = new Alien(100, 5);
            Orc o = new Orc(100, 9);

            //Create AlienPack and add aliens
            AlienPack ap = new AlienPack();
            ap.AddAlien(p);
            ap.AddAlien(a);
            ap.AddAlien(o);

            Console.WriteLine("Alien pack damage = {0}", ap.CalculateDamage());

            p.ShealthMode = true;
            Console.WriteLine("Alien pack damage = {0}, (predator in shealthMode)", ap.CalculateDamage());

            p.ShealthMode = false;
            o.TakeDamage(1);
            Console.WriteLine("Alien pack damage = {0}, (orc with less than full healtth)", ap.CalculateDamage());


            Console.ReadKey();
        }



    }
}
