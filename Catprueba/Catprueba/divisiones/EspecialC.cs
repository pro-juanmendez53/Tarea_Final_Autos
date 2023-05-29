using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catprueba.divisiones
{
    internal class EspecialC : VehiculoBase
    {
        public string aleron { get; set; }
        public string turbo { get; set; }
        public int escapes { get; set; }

        public EspecialC (string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima, int velocidadActual,
            string aleron, string turbo, int escapes) : base (marca, modelo, color, anio, placa, tipo, velocidadMaxima, velocidadActual)
        {
            this.aleron = aleron;
            this.turbo = turbo;
            this.escapes = escapes;
        }


        public void nitroso ()
        {
            if (encendido == 1)
            {
                Console.WriteLine("Puedes Activar el Nitro");
            }
            else
            {
                Console.WriteLine("No puedes activar el nitro porque el auto esta apagado");
            } 
                
        }



    }
}
