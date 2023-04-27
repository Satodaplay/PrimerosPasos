

namespace Dia6
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Propiedades del paciente numero 1");
            Humano Daniel = new Humano("Daniel", "Sastre", "Marrones", 17);
            Daniel.Presentarme();
            Humano Satoda = new Humano("Sa", "To", "Da", 9);
            Satoda.Presentarme();

        }
    }
}
