using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Catprueba.divisiones
{
    internal class PickUp : VehiculoBase 
    {
        //CARACTERISTICAS PROPIAS QUE TIENE UN PICKUP
        public string neblineras { get; set; }
        public string cuatropor { get; set; }
        public string snorkel { get; set; }
      


        public PickUp (string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima, int velocidadActual, string neblineras, 
            string cuatropor, string snorkel) : base (marca, modelo, color, anio, placa, tipo, velocidadMaxima, velocidadActual)
        {
            this.neblineras = neblineras;
            this.cuatropor = cuatropor;
            this.snorkel= snorkel;
        }

        //METODO PROPIO QUE TIENE UN PICKUP
        public void dobletrac()
        {
            if (encendido == 0)
            {
                Console.WriteLine("El carro estas apagado.");
            }
            else
            {
                Console.WriteLine("Funcion 4x4 Activada.");
            }

        }





    }
}
