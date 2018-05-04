using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patrones.Creacionales.BuilderTest;
using Patrones.Creacionales.FactoryMethod;
using Patrones.Creacionales.Prototype;
using Patrones.Creacionales.Singleton;
using Patrones.Creacionales.AbstractFactory;
using Patrones.Estructural.Adapter;
using Patrones.Estructural.Adapter2;

namespace Patrones.Test
{
    [TestClass]
    public class EstructuralesTest
    {
        [TestMethod]
        public void AdapterTest()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }

        [TestMethod]
        public void Adapter2Test()
        {
            PersonaVieja vieja = new PersonaVieja();
            vieja.nombre = "Mirtha";
            vieja.apellido = "Legrand";
            vieja.fechaNacimiento = new DateTime(1910, 1, 1);

            ViejaToNuevaAdapter nueva = new ViejaToNuevaAdapter(vieja);
            Console.WriteLine("Edad: " + nueva.edad);
            Console.WriteLine("Nombre: " + nueva.nombre);

            Console.WriteLine("Paso por el cirujano...");

            nueva.edad = 30;
            nueva.nombre = "China Suarez";
            Console.WriteLine("Edad: " + nueva.edad);
            Console.WriteLine("Nombre: " + nueva.nombre);
        }
    }
}
