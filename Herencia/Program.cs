using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalAcuatico delfin = new AnimalAcuatico();
            AnimalTerrestre elefante = new AnimalTerrestre();
            Kanguro kanguro = new Kanguro();

            List<Animal> animales = new Animal();

            Animal tiburon = new AnimalAcuatico();
            tiburon.Nombre = "Tiburon";
            /*El casting se usa para poder usar los valores de
              Animal Acuatico*/
            ((AnimalAcuatico)tiburon).Nadar();

            delfin.Nombre = "Delfinin";
            elefante.Nombre = "Elenin";

            delfin.Comer();
            delfin.Nadar();

            elefante.Comer();
            elefante.Caminar();

            kanguro.Caminar();
            kanguro.Saltar();
            kanguro.Comer();

            animales.Add(delfin);
            animales.Add(tiburon);
            animales.Add(elefante);
            animales.Add(kanguro);

            foreach (var animal in animales)
            {
                Console.Write(animal.Nombre);
                (animal.GetType() == typeof(AnimalAcuatico))
                {
                    ((AnimalAcuatico)animal).Nadar();
                }
            }

            Console.ReadLine();
        }
    }
}
