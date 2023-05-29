using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Catprueba.divisiones
{
    internal interface IVehiculo
    {
        string marca { get; set; }
        string modelo { get; set; }
        string color { get; set; }
        int anio { get; set; }
        string placa { get; set; }
        string tipo { get; set; }
        int velocidadMaxima { get; set; }
        int velocidadActual { get; set; }

        

        void bocina();
        void acelerar(int cuanto);
        void encender();
        void apagar();
        void frenar(int cuanto);


    }

}
