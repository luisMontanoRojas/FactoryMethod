using System;

namespace FactoryMethod
{
    class Program
    {
        public static double operation;
        public static BebidaEmbriagante oBebida;
        static void Main(string[] args)
        {
            menu();
           
        }

        static void menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("----------CALCULADOR DE BEBIDA EMBRIAGANTE----------");
                Console.WriteLine("1.- VINO TINTO");
                Console.WriteLine("2.- CERVEZA");
                Console.WriteLine("0.- Salir");
                Console.WriteLine("----------------------------------------------------");
                operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        oBebida = Creador.CreadorBebida(Creador.vinoTinto);
                        showResult();
                        break;
                    case 2:
                        oBebida = Creador.CreadorBebida(Creador.cerveza);
                        showResult();
                        break;   
                }

            } while (operation != 0);

        }

        static void showResult()
        {
            Console.WriteLine("Embriaga {0}%", oBebida.CuantoMeEmbriagaPorHora());
            Console.ReadLine();
        }
    }
}
