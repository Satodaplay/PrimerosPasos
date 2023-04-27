

namespace Dia12
{

    class Program
    {

        static void Main(string[] args)
        {

            Random respuesta = new Random();
            int numRespuesta;
            string Afirmacion = "Si";
            string Negacion = "No";
            string Duda = "Quizas";

            for (int i = 0; i < 3; i++)
            {
                numRespuesta = respuesta.Next(0, 3);
                switch (numRespuesta)
                {
                    case 0:
                        numRespuesta = 1;
                        Console.WriteLine(Afirmacion);
                        break;

                    case 1:
                        numRespuesta= 2;
                        Console.WriteLine(Negacion);
                        break;

                    case 2:
                        numRespuesta= 3;
                        Console.WriteLine(Duda);
                        break;

                }
            }

        }
    }
}
