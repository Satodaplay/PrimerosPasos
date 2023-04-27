

using System.ComponentModel;

namespace Dia3
{

    class Program
    {


     static void Main(String[] args)
        {
            Console.WriteLine("ponga el numero que quiere dividir por 0");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int value);

            try
            {
                Console.WriteLine(value / 0);
            }
            catch (Exception)
            {
                 Console.WriteLine("Tu que eres tonto? No se pueden dividir numero entre 0");
               
            }

        }

    }


}
