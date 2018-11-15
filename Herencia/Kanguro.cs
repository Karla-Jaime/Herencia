using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Kanguro : AnimalTerrestre
    {
        public Kanguro()
        {
            Nombre= "Kanguro";
        }

        public void Saltar()
        {
            Console.WriteLine("Hola soy un" + Nombre + "Estoy Saltando");
        }
    }
}
