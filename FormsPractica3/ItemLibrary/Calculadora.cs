using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibrary
{
    public class Calculadora
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public Calculadora(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public int Suma()
        {
            return Numero1 + Numero2;
        }

        public int Resta()
        {
            return Numero1 - Numero2;
        }

        public int Multiplicacion()
        {
            return Numero1 * Numero2;
        }

        public int Division()
        {
            if (Numero2 != 0)
            {
                return Numero1 / Numero2;
            }
            else
            {
                throw new InvalidOperationException("No se puede dividir por cero.");
            }
        }
    }

}
