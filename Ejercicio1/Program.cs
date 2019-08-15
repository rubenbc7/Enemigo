using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemigo enemigo = new Enemigo();

            enemigo.Explode = true;
            enemigo.Movement = true;
            enemigo.Shoot = true;

            enemigo.PosX = 896;
            enemigo.PosY = -312;

            Console.WriteLine("Posición en X: " + enemigo.PosX);
            Console.WriteLine("Posición en Y: " + enemigo.PosY);



            try
            {
                enemigo.Score = 200;
                Console.WriteLine("Score: " + enemigo.Score);
            }

            catch(Exception se)
            {
                Console.WriteLine("Score menor de 100");
            }

            Console.ReadLine();
        }
    }
}
