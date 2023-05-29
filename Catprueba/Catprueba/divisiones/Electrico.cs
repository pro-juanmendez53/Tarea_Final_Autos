using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catprueba.divisiones
{
    internal class Electrico : VehiculoBase
    {

        public string cargador { get; set; }
        public string television { get; set; }
        public int escapes { get; set; }





        public Electrico (string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima, int velocidadActual,
            string cargador, string television, int escapes) : base (marca, modelo, color, anio, placa, tipo, velocidadMaxima, velocidadActual)
        {
            this.cargador = cargador;
            this.television = television;
            this.escapes = escapes;

        }

        public void piloto_auto ()
        {
           if (encendido == 1)
            {
                Console.WriteLine("Piloto automatico activado");
            }
           else
            {
                Console.WriteLine("El auto esta apagado");
            }
        }


    }
}
