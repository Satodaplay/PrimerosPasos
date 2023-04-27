

namespace Dia4
{

    class Program
    {

        static void Main(string[] args)
        {
            string nombreUsuario = "";
            string nombreUsuarioRegistrado = "";
            string contraseñaUsuario = "";
            string contraseñaUsuario2 = "";
            string contraseñausuarioRegistrado = "";
            bool logeado = false;


            Console.WriteLine("Porfavor escriba su nuevo nombre de usuario");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Porfavor ingrse su nueva contraseña");
            contraseñaUsuario = Console.ReadLine();

            Console.WriteLine("Vuelva a intruducir su contraseña");
            contraseñaUsuario2 = Console.ReadLine();

            if (contraseñaUsuario == contraseñaUsuario2)
            {
                Console.WriteLine("Te has logeado correctamente");
                logeado = true;
            }
            else
            {
                Console.WriteLine("Las contraseñas no coinciden");
                Console.WriteLine("Porfavor escriba su nuevo nombre de usuario");
                nombreUsuario = Console.ReadLine();

                Console.WriteLine("Porfavor ingrse su nueva contraseña");
                contraseñaUsuario = Console.ReadLine();

                Console.WriteLine("Vuelva a intruducir su contraseña");
                contraseñaUsuario2 = Console.ReadLine();
                if (contraseñaUsuario == contraseñaUsuario2)
                {
                    Console.WriteLine("Te has logeado correctamente");
                    logeado = true;
                }

            }

            if (logeado = true)
            {
                Console.WriteLine("Porfavor escriba su nombre de usuario para iniciar sesion");
                nombreUsuarioRegistrado = Console.ReadLine();
                if (nombreUsuarioRegistrado == nombreUsuario)
                {
                    Console.WriteLine("Introduzca su contraseña");
                    contraseñausuarioRegistrado = Console.ReadLine();
                    if (contraseñausuarioRegistrado == contraseñaUsuario)
                    {
                        Console.WriteLine("Has iniciado sesion correctamente");
                    }
                    else
                    {
                        Console.WriteLine("Contraseña incorrecta");
                        Console.WriteLine("Introduzca su contraseña");
                        contraseñausuarioRegistrado = Console.ReadLine();
                        if (contraseñausuarioRegistrado == contraseñaUsuario)
                        {
                            Console.WriteLine("Has iniciado sesion correctamente");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nombre de usuario incorrecto");
                    Console.WriteLine("Porfavor escriba su nombre de usuario para iniciar sesion");
                    nombreUsuarioRegistrado = Console.ReadLine();
                    if (nombreUsuarioRegistrado == nombreUsuario)
                    {
                        Console.WriteLine("Introduzca su contraseña");
                        contraseñausuarioRegistrado = Console.ReadLine();
                        if (contraseñausuarioRegistrado == contraseñaUsuario)
                        {
                            Console.WriteLine("Has iniciado sesion correctamente");
                        }
                        else
                        {
                            Console.WriteLine("Contraseña incorrecta");
                            Console.WriteLine("Introduzca su contraseña");
                            contraseñausuarioRegistrado = Console.ReadLine();
                            if (contraseñausuarioRegistrado == contraseñaUsuario)
                            {
                                Console.WriteLine("Has iniciado sesion correctamente");
                            }
                        }
                    }
                   
                }
            }

        }

    }

}
