using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patrones.Creacionales.BuilderTest;
using Patrones.Creacionales.FactoryMethod;
using Patrones.Creacionales.Prototype;
using Patrones.Creacionales.Singleton;
using Patrones.Creacionales.AbstractFactory;

namespace Patrones.Test
{
    [TestClass]
    public class CreacionalesTest
    {
        [TestMethod]
        public void AbstractFactoryTest()
        {
            TvAbstractFactory f1 = new FactoryLcdAzul();
            EnsamblajeTV e1 = new EnsamblajeTV(f1);

            TvAbstractFactory f2 = new FactoryPlasmaAmarillo();
            EnsamblajeTV e2 = new EnsamblajeTV(f2);
        }

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

        [TestMethod]
        public void PrototypeTest()
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Patrones.Creacionales.Prototype.Color(255, 0, 0);
            colormanager["green"] = new Patrones.Creacionales.Prototype.Color(0, 255, 0);
            colormanager["blue"] = new Patrones.Creacionales.Prototype.Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Patrones.Creacionales.Prototype.Color(255, 54, 0);
            colormanager["peace"] = new Patrones.Creacionales.Prototype.Color(128, 211, 128);
            colormanager["flame"] = new Patrones.Creacionales.Prototype.Color(211, 34, 20);

            // User clones selected colors
            Patrones.Creacionales.Prototype.Color color1 = colormanager["red"].Clone() as Patrones.Creacionales.Prototype.Color;
            Patrones.Creacionales.Prototype.Color color2 = colormanager["peace"].Clone() as Patrones.Creacionales.Prototype.Color;
            Patrones.Creacionales.Prototype.Color color3 = colormanager["flame"].Clone() as Patrones.Creacionales.Prototype.Color;
        }

        [TestMethod]
        public void SingletonTest()
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }
        }
    }
}
