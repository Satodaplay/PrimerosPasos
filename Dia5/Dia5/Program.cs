

namespace Dia5
{

    class Program
    {


        static void Main(string[] args)
        {
            string nombreAlumno = "";
            string notas;
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;

            Console.WriteLine("Ingrese el nimbre del aulumno que va a calificar");
            nombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingrese las notas de " + nombreAlumno);

            for (int contador = 0; contador < 3; contador++)
            {
                notas = Console.ReadLine();

                switch (contador)
                {
                    case 1: contador = 0;
                        Int32.TryParse(notas, out nota1);
                        break;

                    case 2: contador = 1;
                        Int32.TryParse(notas, out nota2);
                        break;

                    case 3: contador = 2; 
                        Int32.TryParse(notas, out nota3);
                        break;
                       

                }
                
            }

            Console.WriteLine(nota1 + nota2 + nota3);
        }
    }
}
