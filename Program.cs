using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Media;
namespace Bingo1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();//Aquui basicamente estamos llamando la funcion menu.
        }
        public static void menu()
        {           
            Lista j = new Lista();//Aqui estamos llamando la lista para usar todos los metodos que ella nos proporciona

            Console.ForegroundColor = ConsoleColor.Yellow;//Diseño
            dibujo();//Diseño
            Console.ForegroundColor = ConsoleColor.Yellow;

            
            int op = int.Parse(Console.ReadLine());//Este imput sirve para seleccionar que el tipo de opcion
            do { //Este do while se va a ejecutar mientras el usuario no digite 2
            switch(op)
            {
                case 1:
                        Console.Clear();
                        SoundPlayer plays = new SoundPlayer();
                        plays.SoundLocation = "Introduzca cuantos jugadores van a jugar.wav";
                        plays.Play();
                        Console.WriteLine("\t\t\t\t\t█ █▄░█ ▀█▀ █▀█ █▀█ █▀▄ █░█ ▀█ █▀▀ ▄▀█   █▀▀ █░█ ▄▀█ █▄░█ ▀█▀ ▄▀█ █▀   █▀█ █▀▀ █▀█ █▀ █▀█ █▄░█ ▄▀█ █▀    █▀▄ █▀▀ █▀ █▀▀ ▄▀█ █▄░█   ░░█ █░█ █▀▀ ▄▀█ █▀█ ▀");
                        Console.WriteLine("\t\t\t\t\t█ █░▀█ ░█░ █▀▄ █▄█ █▄▀ █▄█ █▄ █▄▄ █▀█   █▄▄ █▄█ █▀█ █░▀█ ░█░ █▀█ ▄█   █▀▀ ██▄ █▀▄ ▄█ █▄█ █░▀█ █▀█ ▄█    █▄▀ ██▄ ▄█ ██▄ █▀█ █░▀█   █▄█ █▄█ █▄█ █▀█ █▀▄ ▄");
                        Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                        int cantidad = int.Parse(Console.ReadLine());

                        
                        //Este arreglo sirve para proporcionarle la cantidad de personas, y almacenar esos nombres en el arreglo
                        string[] nombre = new string[cantidad];

                        plays.SoundLocation = "Nombre del jugador.wav";
                        plays.Play();

                        for (int i = 0; i<nombre.Length; i++)//Este for dice, que si i es menor que nombre(cantiodad), i se va a ingrementar, es decir se van a estar almacenando los nombres en el arreglo
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                            Console.WriteLine("");
                            Console.WriteLine($"\t\t\t\t\t\t\t█ █▄░█ ▀█▀ █▀█ █▀█ █▀▄ █░█ ▀█ █▀▀ ▄▀█   █▀▀ █░░   █▄░█ █▀█ █▄▄ █▀█ █▀▀   █▀▄ █▀▀ █░░   ░░█ █░█ █▀▀ ▄▀█ █▀▄ █▀█ █▀█ {i+1}:");
                            Console.WriteLine ("\t\t\t\t\t\t\t█ █░▀█ ░█░ █▀▄ █▄█ █▄▀ █▄█ █▄ █▄▄ █▀█   ██▄ █▄▄   █░▀█ █▄█ █▄█ █▀▄ ██▄   █▄▀ ██▄ █▄▄   █▄█ █▄█ █▄█ █▀█ █▄▀ █▄█ █▀▄");
                            Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                            nombre[i] = Console.ReadLine();//aqui estamoa dandole entrada a los nombres en el arreglo
                        }

                        
                        for (int i= 0; i< cantidad; i++)//Este for dice, que si i es menor a la cantidad se va a seguir ingrementando.
                        {
                            int[,] array = new int[5, 5];//Creamos un arreglo para pasarselo por parametro a la lista tablero para asi llenar las tablas del jugador
                            Tablero t = new Tablero(array, nombre);//Aqui estamos llamando la clase tablero y le estamos pasando el arreglo de la linea anterior y el nombre del arreglo de arriba(LINEA 37) por parametro
                            t.tablero();//llamamos el metodo tablero para llenar el arreglo bidimensional
                            j.agregarporcola(t);//aqui le estamos pasando el arreglo a la lista por parametro
                        }

                        j.Juego();//Llamada del juego
                        break;
                        

                }
            } while (op != 2 && j.ganador() != true);

        }
        public static void dibujo()
        {
            SoundPlayer pla = new SoundPlayer();
            pla.SoundLocation = "Bienvenida al bingo.wav";
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t█▄▄ █ ▄▀█ █▄░█ █░█ █▀▀ █▄░█ █ █▀▄ █▀█ █▀");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t█▄█ █ █▀█ █░▀█ ▀▄▀ ██▄ █░▀█ █ █▄▀ █▄█ ▄█");
            Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
            Console.WriteLine("");

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██████╗░██╗███╗░░██╗░██████╗░░█████╗");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔══██╗██║████╗░██║██╔════╝░██╔══██╗");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██████╦╝██║██╔██╗██║██║░░██╗░██║░░██║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔══██╗██║██║╚████║██║░░╚██╗██║░░██║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██████╦╝██║██║░╚███║╚██████╔╝╚█████╔╝");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░░╚════╝░");

            Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
            Thread.Sleep(500);
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t1.Jugar");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t2.Salir");
            Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
            pla.Play();

            


        }
    }
}