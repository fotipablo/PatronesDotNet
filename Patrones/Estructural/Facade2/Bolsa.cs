using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Estructural.Facade2
{
    public class Persona
    {

    }

    public class Cliente : Persona
    {

    }

    public class Interesado : Persona
    {

    }

    public class Propietario : Persona
    {

    }


    public class AdministracionAlquiler
    {

        public void cobro(double monto)
        {

            // Algoritmo

        }

    }


    public class CuentasAPagar
    {

        public void pagoPropietario(double monto)
        {

            // Algoritmo

        }

    }


    public class MuestraPropiedad
    {

        public void mostraPropiedad(int numeroPropiedad)
        {

            // Algoritmo

        }

    }


    public class VentaInmueble
    {

        public void gestionaVenta()
        {

            // Algoritmo

        }

    }


    public class Inmobiliaria
    {


        private MuestraPropiedad muestraPropiedad;

        private VentaInmueble venta;

        private CuentasAPagar cuentasAPagar;

        private AdministracionAlquiler alquiler;


        public Inmobiliaria()
        {

            muestraPropiedad = new MuestraPropiedad();

            venta = new VentaInmueble();

            cuentasAPagar = new CuentasAPagar();

            alquiler = new AdministracionAlquiler();

        }


        public void atencionCliente(Cliente c)
        {

            Console.WriteLine("Atendiendo a un cliente");

        }


        public void atencionPropietario(Propietario p)
        {

            Console.WriteLine("Atendiendo a un propietario");

        }


        public void atencionInteresado(Interesado i)
        {

            Console.WriteLine("Atencion a un interesado en una propiedad");

        }


        public void atencion(Persona p)
        {

            if (p is Cliente) {

                atencionCliente((Cliente)p);

            } else if (p is Propietario) {

                atencionPropietario((Propietario)p);

            } else {

                atencionInteresado((Interesado)p);

            }

        }


        public void mostraPropiedad(int numeroPropiedad)
        {

            muestraPropiedad.mostraPropiedad(numeroPropiedad);

        }


        public void gestionaVenta()
        {

            venta.gestionaVenta();

        }


        public void paga(int monto)
        {

            cuentasAPagar.pagoPropietario(monto);

        }


        public void cobraAlquiler(double monto)
        {

            alquiler.cobro(monto);

        }

    }
}
