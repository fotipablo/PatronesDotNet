using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patrones.Creacionales.BuilderTest;
using Patrones.Creacionales.FactoryMethod;

namespace Patrones.Test
{
    [TestClass]
    public class CreacionalesTest
    {
        [TestMethod]
        public void BuilderTest()
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();


            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }

        [TestMethod]
        public void FactoryMethodTest()
        {
            TrianguloFactory factory = new TrianguloFactory();
            Triangulo triangulo = factory.createTriangulo(10, 20, 30);
            Console.WriteLine(triangulo.getDescripcion());
        }
    }
}
