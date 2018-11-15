using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class AnimalAcuatico : Animal // Tiene que ser publico la clase que hereda y la que recibe la info
    {
         public void Nadar()
        {
            Console.WriteLine("Hola soy un" + Nombre + "Estoy Nadando");
        }
    }
}
