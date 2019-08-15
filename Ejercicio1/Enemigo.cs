using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Enemigo
    {
        public bool Explode { get; set;}
        public bool Shoot { get; set; }
        public bool Movement { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        private int _score;
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                if(value >= 100)
                {
                    _score = value;
                }

                else
                {
                    throw new Exception("Score menor a 100");
                }

            }
        }

        public void explotar() { }
        public void moverse() { }
        public void disparar() { }



    }
}
