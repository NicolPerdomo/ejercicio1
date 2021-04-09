using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static Class1 pantalla = new Class1();

        static void Main(string[] args)
        
        {
            int cond;
            do {
                Console.Clear();
                pantalla.Screen();


                Console.SetCursorPosition(45, 2);
                Console.WriteLine("1.quienes somos");
                Console.SetCursorPosition(45, 6);
                Console.WriteLine("2.menu aplicacion");
                Console.SetCursorPosition(45, 10);
                Console.WriteLine("0.salir");
                Console.SetCursorPosition(45, 14);
                cond = Convert.ToInt32(Console.ReadLine());

                switch (cond)
                {
                    case 1:
                        quienesSomos();
                        break;
                    case 2:
                        menuAplicacion();
                        break;
                    case 0:
                        Console.SetCursorPosition(45,18);
                        Console.WriteLine("saliendo de la aplicacion");
                        break;
                    default:
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("opcion no valida");
                        break;

                }

                Console.SetCursorPosition(40, 23);
                Console.WriteLine("presione enter para continuar...");
                Console.ReadKey();
            } while (cond!=0);


            
        }

        static void quienesSomos()
        {
            Console.Clear();
            pantalla.Screen();

            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Milena Pinzon");
            Console.SetCursorPosition(45, 6);
            Console.WriteLine("Nycol Perdomo");
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("Roger Cardona");
            


        }
        static void menuAplicacion()
        {
            int cond;
            do
            {
                

                Console.Clear();
                pantalla.Screen();

                Console.SetCursorPosition(45, 2);
                Console.WriteLine("1.agregar personaje");
                Console.SetCursorPosition(45, 6);
                Console.WriteLine("2.listar personaje");
                Console.SetCursorPosition(45, 10);
                Console.WriteLine("3.buscar personaje");
                Console.SetCursorPosition(45, 14);
                Console.WriteLine("4.salir al menu principal");

                
                Console.SetCursorPosition(45, 17);
                cond = Convert.ToInt32(Console.ReadLine());


                switch (cond)
                {
                    
                    case 1:
                        Console.Clear();
                        pantalla.Screen();
                        Console.SetCursorPosition(45, 6);
                        Console.WriteLine("pagina en proceso..");
                        break;
                    case 2:
                        Console.Clear();
                        pantalla.Screen();
                        Console.SetCursorPosition(45, 6);
                        Console.WriteLine("pagina en proceso..");
                        break;
                    case 3:
                        Console.Clear();
                        pantalla.Screen();
                        Console.SetCursorPosition(45, 6);
                        Console.WriteLine("pagina en proceso..");
                        break;
                    case 4:
                        Console.SetCursorPosition(45, 19);
                        Console.WriteLine("saliendo de la aplicacion");
                        break;
                    default:
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("opcion no valida");
                        break;
                        Console.SetCursorPosition(45, 24);
                        Console.WriteLine("presione enter para continuar..");
                }
                Console.ReadKey();
            } while (cond!= 4);

        }



    }

}
