using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
    class Carta
    {
        private int numero;
        private string[] palos = {"Diamantes", "Picas", "Corazones", "Treboles" };
        private int palo;

        //Constructor
        public Carta(int numeroCarta, int paloCarta)
        {
            numero = numeroCarta;
            palo = paloCarta;
        }
        public override string ToString()
        {
            return (numero + " de " + palos[palo]);
        }
        
        //GETTERS Y SETTERS
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Palo
        {
            get { return palo; }
            set { palo = value; }
        }
    }
}
