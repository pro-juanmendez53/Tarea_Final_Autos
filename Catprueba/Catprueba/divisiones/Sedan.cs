using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catprueba.divisiones
{
    internal class Sedan : VehiculoBase
    {

        public string lucesled { get; set; }
        public string quemacoco { get; set; }
        public string startbo { get; set; }



        public Sedan (string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima, int velocidadActual, string lucesled,
            string quemacoco, string startbo) : base (marca, modelo, color, anio, placa, tipo, velocidadMaxima, velocidadActual)
        {

            this.lucesled= lucesled;
            this.quemacoco=quemacoco;
            this.startbo= startbo;

        }


        public void inferiorluz ()
        {
            if (encendido == 0)
            {
                Console.WriteLine("El carro estas apagado, por lo tanto no hay energia para las luces inferiores");
            }
            else
            {
                Console.WriteLine("Luces inferiores activadas.");
            }
        }

    }




}
