

namespace Calculadora
{

    class Program
    {

        static void Main(string[] args)
        {

            int signo;

            Console.WriteLine("Que te gustaria operar?");
            Console.WriteLine("1 (+)");
            Console.WriteLine("2 (-)");
            Console.WriteLine("3 (*)");
            Console.WriteLine("4 (/)");
            string signo1 = Console.ReadLine();
            Int32.TryParse(signo1, out signo);

            switch (signo)
            {
                case 1: 
                    signo = 1;
                    Program.Suma();
                    break;

                case 2:
                    signo = 2;
                    Program.Resta();
                    break;
                case 3:
                    signo = 3;
                    Program.Multiplicacion();
                    break;
                case 4:
                    signo = 4;
                    Program.Division();
                    break;
                default:
                    Console.WriteLine("Porfavor escriba un numero valido");
                    break;
            }

        }

        static void Suma()
        {

            int sX = 0;
            int sY = 0;

            Console.WriteLine("Introduce el primer numero");
            string sX1 = Console.ReadLine();
            Int32.TryParse(sX1, out sX);
            Console.WriteLine("Introduce el segundo numero");
            string sY1 = Console.ReadLine();
            Int32.TryParse(sY1, out sY);
            Console.WriteLine("{0} + {1} = {2}", sX, sY, sX+sY);

        }

        static void Resta()
        {

            int rX = 0;
            int rY = 0;

            Console.WriteLine("Introduce el primer numero");
            string rX1 = Console.ReadLine();
            Int32.TryParse(rX1, out rX);
            Console.WriteLine("Introduce el segundo numero");
            string rY1 = Console.ReadLine();
            Int32.TryParse(rY1, out rY);
            Console.WriteLine("{0} - {1} = {2}", rX, rY, rX - rY);

        }

        static void Multiplicacion()
        {

            int mX = 0;
            int mY = 0;

            Console.WriteLine("Introduce el primer numero");
            string mX1 = Console.ReadLine();
            Int32.TryParse(mX1, out mX);
            Console.WriteLine("Introduce el segundo numero");
            string mY1 = Console.ReadLine();
            Int32.TryParse(mY1, out mY);
            Console.WriteLine("{0} * {1} = {2}", mX, mY, mX * mY);

        }

        static void Division()
        {

            int dX = 0;
            int dY = 0;

            Console.WriteLine("Introduce el primer numero");
            string dX1 = Console.ReadLine();
            Int32.TryParse(dX1, out dX);
            Console.WriteLine("Introduce el segundo numero");
            string dY1 = Console.ReadLine();
            Int32.TryParse(dY1, out dY);
            Console.WriteLine("{0} / {1} = {2}", dX, dY, dX / dY);

        }

    }
}