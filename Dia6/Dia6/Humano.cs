using System;

namespace Dia6
{
    internal class Humano
    {
        private string Nombre;
        private string Apellido;
        private string ColorOjos;
        private int Edad;

        public Humano(string NombreHumano, string ApellidoHumano, string ColorOjosHumano, int EdadHumano) 
        {
            Nombre = NombreHumano;
            Apellido = ApellidoHumano;
            ColorOjos = ColorOjosHumano;
            Edad = EdadHumano;
        }
        
        public void Presentarme()
        {
            Console.WriteLine("Soy {0} {1} {2} {3}", Nombre, Apellido, ColorOjos, Edad);
        }

    }
}
