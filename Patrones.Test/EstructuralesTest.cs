using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patrones.Creacionales.BuilderTest;
using Patrones.Creacionales.FactoryMethod;
using Patrones.Creacionales.Prototype;
using Patrones.Creacionales.Singleton;
using Patrones.Creacionales.AbstractFactory;
using Patrones.Estructural.Adapter;

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
    }
}
