

namespace Dia8
{

    class Progam
    {

        static void Main(string[] args)
        {

            string[][] Nombres = new string[][]
            {
                new string[] {"Daniel", "Maria"},
                new string[] {"Pamela", "Auba", "Andrea", "Jenny"},
                new string[] {"Lorena", "Laura", "Jose" }

            };
            

            Console.WriteLine("Hola {0} te presento a {1}", Nombres[0][1], Nombres[1][0]);
            Console.WriteLine("Hola {0} te presento a {1}", Nombres[0][0], Nombres[1][1]);
            Console.WriteLine("Hola {0} te presento a {1}", Nombres[2][0], Nombres[1][2]);
            Console.WriteLine("Hola {0} te presento a {1}", Nombres[2][1], Nombres[1][3]);

        }
    }
}
