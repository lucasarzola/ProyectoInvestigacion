using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamiento.Model
{
    public class Plaza
    {
        public int Id { get; set; }
        public string Posicion { get; set; } // posicion geografia de la plaza dentro del establecimiento
        public bool Estado { get; set; }
        public int Tipo { get; set; } // determina el tipo /1 para autos /2 para motos 

        public enum Values
        {
            Auto = 1,
            Moto = 2
        }

    }

}
