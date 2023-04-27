

namespace Dia4_2
{

    class Program
    {
        static void Main(string[] args)
        {
            int temperatura;
            string temperatura2;
            bool temperaturaNumero = false;

            Console.WriteLine("Ingrese una temperatura");
            temperatura2 = Console.ReadLine();
            Int32.TryParse(temperatura2 , out temperatura);
            if (Int32.TryParse(temperatura2, out temperatura))
            {
                temperaturaNumero = true;
                if (temperaturaNumero =true && temperatura <= 15)
                {
                    Console.WriteLine("Hace mucho frio");
                }
                else if (temperaturaNumero = true && temperatura >= 16 && temperatura <= 28)
                {
                    Console.WriteLine("Hace un clima agradable");
                }
                else if (temperaturaNumero = true && temperatura > 28)
                {
                    Console.WriteLine("Hace mucho calor");
                }
            }
            else
            {
                Console.WriteLine("Temperatura incorrecta");
            }
        }

    }

}