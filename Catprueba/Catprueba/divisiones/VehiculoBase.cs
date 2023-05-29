using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catprueba.divisiones
{
    internal class VehiculoBase : IVehiculo
    {
        public string marca { get ; set ; }
        public string modelo { get ; set ; }
        public string color { get ; set ; }
        public int anio { get ; set ; }
        public string placa { get ; set ; }
        public string tipo { get ; set ; }
        public int velocidadMaxima { get ; set ; }   //determinar velocidad fija, la velocidad maxima que puede alcanzar el auto
        public int velocidadActual { get ; set ; }



        public int encendido = 0;

        public void acelerar(int cuanto)
        {
            
            if (encendido == 0)
            {
                Console.WriteLine("No es posible acelerar porque el carro esta apagado");
            }
            else
            {
                Console.WriteLine("ESTAS ACELERANDO " + cuanto +  " km/h ");   //cambiar, solo es una prueba
            }

        }

        public void apagar()
        {
            encendido = 0;
           if (encendido == 0)

            {
                Console.WriteLine("El carro esta apagado");
            }
            else
            {
                Console.WriteLine("El carro aun esta encendido");   // cambiar, solo es una prueba 
            }



        }

        public void bocina()
        {
            Console.WriteLine("Has bocinado");
            Console.Beep(1000,500);
            Console.ReadKey();

        }

        public void encender()
        {
            encendido = 1; 
            if (encendido==0)
            {
                Console.WriteLine("\nEl carro estas apagado, enciendelo");
            }
            else
            {
                Console.WriteLine("\nEl carro se ha encendido");
            }
        }

        public void frenar(int cuanto)
        {

            if (encendido == 0)
            {
                Console.WriteLine("El carro estas apagado.");
            }
            else
            {
                Console.WriteLine("Has disminuido " + cuanto + " km/h de velocidad");
            }

        }

        public VehiculoBase(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima, int velocidadActual)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.anio = anio;
            this.placa = placa;
            this.tipo = tipo;
            this.velocidadMaxima= velocidadMaxima;
            this.velocidadActual= velocidadActual;
            Console.WriteLine("AUTO AGREGADO A LA LISTA:\n");

        }



    }


}
