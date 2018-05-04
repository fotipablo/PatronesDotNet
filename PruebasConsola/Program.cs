using Patrones.Comportamiento.ChainOfResponsability;
using Patrones.Comportamiento.Command;
using Patrones.Comportamiento.Command2;
using Patrones.Comportamiento.Interpreter;
using Patrones.Comportamiento.Iterator;
using Patrones.Comportamiento.Mediator;
using Patrones.Comportamiento.Memento;
using Patrones.Comportamiento.Observer;
using Patrones.Comportamiento.State;
using Patrones.Comportamiento.Strategy;
using Patrones.Comportamiento.Visitor;
using Patrones.Creacionales.AbstractFactory;
using Patrones.Creacionales.Builder;
using Patrones.Creacionales.FactoryMethod;
using Patrones.Creacionales.Prototype;
using Patrones.Creacionales.Singleton;
using Patrones.Estructural.Adapter;
using Patrones.Estructural.Adapter2;
using Patrones.Estructural.Bridge;
using Patrones.Estructural.Bridge2;
using Patrones.Estructural.Composite;
using Patrones.Estructural.Decorator;
using Patrones.Estructural.Facade;
using Patrones.Estructural.Facade2;
using Patrones.Estructural.Flyweight;
using Patrones.Estructural.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsola
{
    enum PatronEnum
    {
        #region Creacionales

        AbstractFactory,
        Builder,
        FactoryMethod,
        Prototype,
        Singleton,

        #endregion

        #region Estructurales

        Adapter,
        Adapter2,
        Bridge,
        Bridge2,
        Composite,
        Decorator,
        Facade,
        Facade2,
        Flyweight,
        Proxy,

        #endregion

        #region Comportamiento

        ChainOfResponsability,
        Command,
        Command2,
        Interpreter,
        Iterator,
        Mediator,
        Memento,
        Observer,
        State,
        Strategy,
        TemplateMethod,
        Visitor

        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {

            PatronEnum patronEjec = PatronEnum.ChainOfResponsability;

            switch (patronEjec)
            {

                #region Creacionales

                case PatronEnum.AbstractFactory:
                    AbstractFactory();
                    break;
                case PatronEnum.Builder:
                    Builder();
                    break;
                case PatronEnum.FactoryMethod:
                    FactoryMethod();
                    break;
                case PatronEnum.Prototype:
                    Prototype();
                    break;
                case PatronEnum.Singleton:
                    Singleton();
                    break;

                #endregion

                #region Estructurales

                case PatronEnum.Adapter:
                    Adapter();
                    break;
                case PatronEnum.Adapter2:
                    Adapter2();
                    break;
                case PatronEnum.Bridge:
                    Bridge();
                    break;
                case PatronEnum.Bridge2:
                    Bridge2();
                    break;
                case PatronEnum.Composite:
                    Composite();
                    break;
                case PatronEnum.Decorator:
                    Decorator();
                    break;
                case PatronEnum.Facade:
                    Facade();
                    break;
                case PatronEnum.Facade2:
                    Facade2();
                    break;
                case PatronEnum.Flyweight:
                    Flyweight();
                    break;
                case PatronEnum.Proxy:
                    Proxy();
                    break;

                #endregion

                #region Comportamiento

                case PatronEnum.ChainOfResponsability:
                    ChainOfResponsability();
                    break;
                case PatronEnum.Command:
                    Command();
                    break;
                case PatronEnum.Command2:
                    Command2();
                    break;
                case PatronEnum.Interpreter:
                    Interpreter();
                    break;
                case PatronEnum.Iterator:
                    Iterator();
                    break;
                case PatronEnum.Mediator:
                    Mediator();
                    break;
                case PatronEnum.Memento:
                    Memento();
                    break;
                case PatronEnum.Observer:
                    Observer();
                    break;
                case PatronEnum.State:
                    State();
                    break;
                case PatronEnum.Strategy:
                    Strategy();
                    break;
                case PatronEnum.TemplateMethod:
                    TemplateMethod();
                    break;
                case PatronEnum.Visitor:
                    Visitor();
                    break;
                    //();

                    #endregion
            }

            // Wait for user
            Console.ReadKey();
        }

        #region Creacionales

        private static void AbstractFactory()
        {
            TvAbstractFactory f1 = new FactoryLcdAzul();
            EnsamblajeTV e1 = new EnsamblajeTV(f1);

            TvAbstractFactory f2 = new FactoryPlasmaAmarillo();
            EnsamblajeTV e2 = new EnsamblajeTV(f2);
        }

        private static void Builder()
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

        private static void FactoryMethod()
        {
            TrianguloFactory factory = new TrianguloFactory();
            Triangulo triangulo = factory.createTriangulo(10, 20, 30);
            Console.WriteLine(triangulo.getDescripcion());
        }

        private static void Prototype()
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

        private static void Singleton()
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

        #endregion

        #region Estructurales

        private static void Adapter()
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

        private static void Adapter2()
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

        private static void Bridge()
        {
            // Create RefinedAbstraction
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();
        }

        private static void Bridge2()
        {
            Rectangulo rec = new Rectangulo(new DibujandoPunteado(), 1, 1, 2, 2);
            rec.dibuja();

            Circulo cir = new Circulo(new DibujandoNormal(), 1, 2, 3);
            cir.dibuja();

        }

        private static void Composite()
        {
            // Create a tree structure 
            CompositeElement root =
              new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            CompositeElement comp =
              new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            PrimitiveElement pe =
              new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);
        }

        private static void Decorator()
        {
            List<IVendible> autos = new List<IVendible>();

            IVendible fiat = new FiatUno();
            autos.Add(fiat);

            IVendible ford = new FordKa();
            autos.Add(ford);


            IVendible fiatAire = new FiatUno();
            fiatAire = new AireAcondicionado(fiatAire);
            autos.Add(fiatAire);

            IVendible fordCierre = new FordKa();
            fordCierre = new CierreCentralizado(fordCierre);
            autos.Add(fordCierre);

            IVendible fordCierreAire = new FordKa();
            fordCierreAire = new CierreCentralizado(fordCierreAire);
            fordCierreAire = new AireAcondicionado(fordCierreAire);
            autos.Add(fordCierreAire);

            IVendible fordCierreAireCd = new FordKa();
            fordCierreAireCd = new CierreCentralizado(fordCierreAireCd);
            fordCierreAireCd = new AireAcondicionado(fordCierreAireCd);
            fordCierreAireCd = new CdPlayer(fordCierreAireCd);
            autos.Add(fordCierreAireCd);

            foreach (IVendible auto in autos)
            {
                Console.WriteLine("Auto: " + auto.getDescripcion());
                Console.WriteLine("Su precio es: " + auto.getPrecio());
                Console.WriteLine("--------");
            }

            Console.ReadKey();
        }

        private static void Facade()
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
        }

        private static void Facade2()
        {
            Cliente c = new Cliente();

            Interesado i = new Interesado();

            Inmobiliaria inmo = new Inmobiliaria();

            inmo.atencionCliente(c);

            inmo.atencionInteresado(i);


            MuestraPropiedad muestraPropiedad = new MuestraPropiedad();

            muestraPropiedad.mostraPropiedad(123);

            VentaInmueble venta = new VentaInmueble();

            venta.gestionaVenta();

            AdministracionAlquiler alquiler = new AdministracionAlquiler();

            alquiler.cobro(1200);

            CuentasAPagar cuentasAPagar = new CuentasAPagar();

            cuentasAPagar.pagoPropietario(1100);


            // Lo mismo pero despues del Facade

            Inmobiliaria inmo2 = new Inmobiliaria();

            inmo2.atencion(i);

            inmo2.atencion(c);

            inmo2.mostraPropiedad(123);

            inmo2.gestionaVenta();

            inmo2.cobraAlquiler(1200);

            inmo2.paga(1100);

            Console.ReadKey();
        }

        private static void Flyweight()
        {
            // Arbitrary extrinsic state
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new
              UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);
        }

        private static void Proxy()
        {
            // Create math proxy
            MathProxy proxy = new MathProxy();

            // Do the math
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
        }

        #endregion

        #region Comportamiento

        private static void ChainOfResponsability()
        {
            Banco banco = new Banco();

            banco.solicitudPrestamo(56000);

            Console.ReadKey();
        }

        private static void Command()
        {
            IServer server = new ArgentinaServer();
            Patrones.Comportamiento.Command.ICommand command = new PrendeServer(server);
            Invocador serverAdmin = new Invocador(command);
            serverAdmin.run();
        }

        private static void Command2()
        {
            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }

        private static void Interpreter()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}",
              roman, context.Output);
        }

        private static void Iterator()
        {
            // Build a collection
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Create iterator
            Iterator iterator = collection.CreateIterator();

            // Skip every other item
            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Mediator()
        {
            // Create chatroom
            Chatroom chatroom = new Chatroom();

            // Create participants and register them
            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");
        }

        private static void Memento()
        {
            Caretaker ct = new Caretaker();

            Patrones.Comportamiento.Memento.Persona p = new Patrones.Comportamiento.Memento.Persona();
            p.nombre = "Maxi";
            p.nombre = "Juan";

            ct.addMemento(p.saveToMemento());

            p.nombre = "Pedro";

            ct.addMemento(p.saveToMemento());

            p.nombre = "Diego";

            Memento m1 = ct.getMemento(0);
            Memento m2 = ct.getMemento(1);

            Console.WriteLine(string.Concat("Memento 01: ", m1.getSavedState()));
            Console.WriteLine(string.Concat("Memento 02: ", m2.getSavedState()));

        }

        private static void Observer()
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }

        private static void State()
        {
            // Open a new account
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
        }

        private static void Strategy()
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
        }

        private static void TemplateMethod()
        {
            Patrones.Comportamiento.TemplateMethod.Persona p = new Patrones.Comportamiento.TemplateMethod.Cliente(12121);
            Console.WriteLine("El cliente dice: ");
            Console.WriteLine(p.identificate());

            p = new Patrones.Comportamiento.TemplateMethod.Empleado("AD 41252");
            Console.WriteLine("El empleado dice: ");
            Console.WriteLine(p.identificate());

            p = new Patrones.Comportamiento.TemplateMethod.Socio(46232);
            Console.WriteLine("El socio dice: ");
            Console.WriteLine(p.identificate());



        }

        private static void Visitor()
        {
            ProductoDescuento prod1 = new ProductoDescuento();
            prod1.precio = 100;
            ProductoNormal prod2 = new ProductoNormal();
            prod2.precio = 100;

            IVA iva = new IVA();
            double resul1 = prod1.aceptar(iva);
            double resul2 = prod2.aceptar(iva);

            Console.WriteLine(string.Format("Producto 1: {0} - Precio con IVA: {1}", prod1.precio, resul1));
            Console.WriteLine(string.Format("Producto 2: {0} - Precio con IVA: {1}", prod2.precio, resul2));
        }

        #endregion
    }

}