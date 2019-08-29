using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamiento.Model
{
    public class Usuario
    {
        public int Id { set; get; }
        public string Email { set; get; }
        public string Apyn { set; get; }
        public string Pass { set; get; }
        public int Tipo { get; set; } // determina el tipo /1 para autos /2 para motos 

        public enum Values
        {
            Auto = 1,
            Moto = 2
        }

    }
}
