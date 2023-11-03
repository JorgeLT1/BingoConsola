using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;
using System.Xml.Serialization;
using System.Numerics;

namespace Bingo1._0
{
    //Clase Lista Circular Simple
    internal class Lista
    {
        //Atributos de la lista 
        private Nodo cola;
        private Nodo cabeza;
        public int[] numero;//creamos un arreglo para el metodo tombola
        public int contador;
        public int aleatorio;
        
        //Inicializo la lista
        public Lista()
        {
            aleatorio = 0;
            contador = 0;
            this.numero = numero;
            this.numero = new int[75];
            cola = cabeza;
        }
        public bool esvacia()
        {
            return cabeza == null;
        }
       
        public void agregarporcola(Tablero valor)//Agregamos los datos del tablero por parametros.
        {
            Nodo nuevoNodo = new Nodo(valor);

            if(esvacia())
            {
                cabeza = cola = nuevoNodo;
            }
            else
            {
                cola.siguiente = nuevoNodo;
                cola = nuevoNodo;
            }
            cola.siguiente = cabeza;
        }
        public void tombola()
        {
           
            Random ran = new Random();//Creamos un ramdom para los numeros aleatorios
            do//Do while para que verifique los numeros, si el numero esta repetido se va a volver a ejecutar
            {
                aleatorio = ran.Next(1,75+1);//Generando numeros aleatorios y almacenandolos en la variable aleatoria
            } while (Verificar(aleatorio) == true);
            numero[contador] = aleatorio;//aqui estamos almacenando los numeros que ya han salido para que no se repitan
            contador++;//contador para pasarle el indice al arreglo de cuantos espacios van almacenado
            Console.Clear();
            if (aleatorio < 15+1)//aqui estamos dandole las letras a los aleatorios, si es del 1 al 15 va a salir "B".
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t▀█▀ ▄▀█ █▄▄ █░░ █▀▀ █▀█ █▀█ █▀");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░█░ █▀█ █▄█ █▄▄ ██▄ █▀▄ █▄█ ▄█");
                Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Numero de la tombola: "+"B" + aleatorio);
                Console.WriteLine("-----------------------------------");

            }
            else if (aleatorio >= 16 && aleatorio <= 30+1)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t▀█▀ ▄▀█ █▄▄ █░░ █▀▀ █▀█ █▀█ █▀");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░█░ █▀█ █▄█ █▄▄ ██▄ █▀▄ █▄█ ▄█");
                Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Numero de la tombola: " + "i" + aleatorio);
                Console.WriteLine("-----------------------------------");

            }
            else if (aleatorio >= 31 && aleatorio <= 45+1)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t▀█▀ ▄▀█ █▄▄ █░░ █▀▀ █▀█ █▀█ █▀");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░█░ █▀█ █▄█ █▄▄ ██▄ █▀▄ █▄█ ▄█");
                Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Numero de la tombola: " + "n" + aleatorio);
                Console.WriteLine("-----------------------------------");

            }
            else if (aleatorio >= 46 && aleatorio <= 60+1)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t▀█▀ ▄▀█ █▄▄ █░░ █▀▀ █▀█ █▀█ █▀");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░█░ █▀█ █▄█ █▄▄ ██▄ █▀▄ █▄█ ▄█");
                Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Numero de la tombola: " + "G" + aleatorio);
                Console.WriteLine("-----------------------------------");

            }
            else if (aleatorio >= 61 && aleatorio <= 75+1)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t▀█▀ ▄▀█ █▄▄ █░░ █▀▀ █▀█ █▀█ █▀");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░█░ █▀█ █▄█ █▄▄ ██▄ █▀▄ █▄█ ▄█");
                Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Numero de la tombola: " + "O" + aleatorio);
                Console.WriteLine("-----------------------------------");

            }

        }
        public void Marcar()
        {
            Nodo aux = cabeza;//Nodo aux para recorrer los jugadores y analice cada caso
            do
            {

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {//recorremos el arreglo bidimencional del tablero
                        if (aux.dato.tabla[i, j] == aleatorio)//Si el tablero es igual que aleatorio, se va a intercambiar por 0
                        {
                            aux.dato.tabla[i, j] = 0; 
                        }
                    }
                }
                aux = aux.siguiente; //recorrer los jugadores y analice cada caso
            } while (aux != cabeza);
        }
        public bool Verificar(int num)
        {
            Random r = new Random();
            for (int i = 0; i < 75; i++)
            {

               if (num == numero[i])
                 {
                    return true;
                 }
               
            }
            return false;
        } 
        public bool ganador()
        {
            int conta=0;
            bool verificar = false;
            Nodo aux = cabeza;
            do
            {
               //Diagonal principal

                //analiza cada caso del arreglo, si las posiciones son igual a 0, hay un ganador, en este caso es la diagonal principal, en los siguientes casos son diferentes pero con la misma explicancion
                if (aux.dato.tabla[0, 0] == 0 && aux.dato.tabla[1, 1] == 0 && aux.dato.tabla[2,2] == 0&& aux.dato.tabla[3, 3] == 0&& aux.dato.tabla[4, 4] == 0)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;//Si es true hay un ganador
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();//imprimimos el nombre del jugador
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;//retornamos verificar

                }
                //Ganar Horizontal
                if (aux.dato.tabla[4, 0] == 0 && aux.dato.tabla[4, 1] == 0 && aux.dato.tabla[4, 2] == 0 && aux.dato.tabla[4, 3] == 0 && aux.dato.tabla[4, 4] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;

                }
                if (aux.dato.tabla[3, 0] == 0 && aux.dato.tabla[3, 1] == 0 && aux.dato.tabla[3, 2] == 0 && aux.dato.tabla[3, 3] == 0 && aux.dato.tabla[3, 4] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;

                }
                if (aux.dato.tabla[2, 0] == 0 && aux.dato.tabla[2, 1] == 0 && aux.dato.tabla[2, 2] == 0 && aux.dato.tabla[2, 3] == 0 && aux.dato.tabla[2, 4] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;

                }
                if (aux.dato.tabla[1, 0] == 0 && aux.dato.tabla[1, 1] == 0 && aux.dato.tabla[1, 2] == 0 && aux.dato.tabla[1, 3] == 0 && aux.dato.tabla[1, 4] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;
                }
                //Ganar diagonal secundaria
                if (aux.dato.tabla[0, 4] == 0 && aux.dato.tabla[1, 3] == 0 && aux.dato.tabla[2, 2] == 0 && aux.dato.tabla[3, 1] == 0 && aux.dato.tabla[4, 0] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;
                }
                //Ganar vertiacalmente
                if (aux.dato.tabla[0, 0] == 0 && aux.dato.tabla[1, 0] == 0 && aux.dato.tabla[2, 0] == 0 && aux.dato.tabla[3, 0] == 0 && aux.dato.tabla[4, 0] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;
                }
                if (aux.dato.tabla[0, 1] == 0 && aux.dato.tabla[1, 1] == 0 && aux.dato.tabla[2, 1] == 0 && aux.dato.tabla[3, 1] == 0 && aux.dato.tabla[4, 1] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;
                }
                if (aux.dato.tabla[0, 2] == 0 && aux.dato.tabla[1, 2] == 0 && aux.dato.tabla[2, 2] == 0 && aux.dato.tabla[3, 2] == 0 && aux.dato.tabla[4, 2] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;
                }
                if (aux.dato.tabla[0, 3] == 0 && aux.dato.tabla[1, 3] == 0 && aux.dato.tabla[2, 3] == 0 && aux.dato.tabla[3, 3] == 0 && aux.dato.tabla[4, 3] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;
                }
                if (aux.dato.tabla[0, 4] == 0 && aux.dato.tabla[1, 4] == 0 && aux.dato.tabla[2, 4] == 0 && aux.dato.tabla[3, 4] == 0 && aux.dato.tabla[4, 4] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;
                }
                //Ganar horizontal 
                if (aux.dato.tabla[0, 0] == 0 && aux.dato.tabla[0, 1] == 0 && aux.dato.tabla[0, 2] == 0 && aux.dato.tabla[0, 3] == 0 && aux.dato.tabla[0, 4] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verificar = true;
                    Console.Clear();
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = "Ganar.wav";
                    player.Play();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + aux.dato.nombre[conta]); Console.ReadKey();
                    Console.WriteLine("\r\n ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄ ▄▄");
                    return verificar;
                }
                conta++;
                aux = aux.siguiente;//Analiza cada jugador a ver cual ha ganado
            } while (aux != cabeza);

            return false;
        }
        public void imprimir()
        {

            Nodo aux = cabeza;
            int cont = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                //Nombre del jugador
                Console.WriteLine("Nombre del Jugador: " + aux.dato.nombre[cont]);
                Console.ForegroundColor = ConsoleColor.Green;


                Console.WriteLine("-----------------------------------");
                Console.WriteLine("B\tI\tN\tG\tO");
                Console.WriteLine("-----------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                //recorremos el arreglo bidimencional
                for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write($"{aux.dato.tabla[i, j]}\t");//Imprimimos tablero
                        }
                        Console.WriteLine("\n\n");
                    }
                    cont++;
                    aux = aux.siguiente;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----------------------------------");

            } while (aux != cabeza);
        }
        //Metodo juego
        public void Juego()
        {
            do//do while para que si hay un ganador no se vuelva a repetir y gane el usuario
            {
                Marcar();//marca el tablero
                tombola();//proporciona numero aletario
                Sonidos();//Musica como su nombre lo proporciona

                imprimir();//imprimimos tablero, nombre del jugador
                Console.WriteLine("Introduzca una letra para continuar...");
                Console.ReadKey();
            } while (ganador() != true);

        }
        //Sonidos
        public void Sonidos()
        {
            SoundPlayer player = new SoundPlayer();

            if (aleatorio == 1)
            {
                player.SoundLocation = "B1.wav";
                player.Play();
            }
            else if(aleatorio == 2)
            {
                player.SoundLocation = "B2.wav";
                player.Play();
            }
            else if(aleatorio == 3)
            {

                player.SoundLocation = "B3.wav";
                player.Play();
            }
            else if(aleatorio==4)
            {
                player.SoundLocation = "B4.wav";
                player.Play();
            }
            else if(aleatorio == 5)
            {
                player.SoundLocation = "B5.wav";
                player.Play();
            }
            else if(aleatorio ==6)
            {
                player.SoundLocation = "B6.wav";
                player.Play();
            }
            else if(aleatorio == 7)
            {
                player.SoundLocation = "B7.wav";
                player.Play();
            }
            else if(aleatorio==8)
            {
                player.SoundLocation = "B8.wav";
                player.Play();
            }
            else if(aleatorio==9)
            {
                player.SoundLocation = "B9.wav";
                player.Play();
            }
            else if(aleatorio==10)
            {
                player.SoundLocation = "B10.wav";
                player.Play();
            }
            else if(aleatorio==11)
            {
                player.SoundLocation = "B11.wav";
                player.Play();
            }
            else if(aleatorio==12)
            {
                player.SoundLocation = "B12.wav";
                player.Play();
            }
            if (aleatorio == 13)
            {
                player.SoundLocation = "B13.wav";
                player.Play();
            }
            else if (aleatorio == 14)
            {
                player.SoundLocation = "b14.wav";
                player.Play();
            }
            else if (aleatorio == 15)
            {
                player.SoundLocation = "b15.wav";
                player.Play();
            }
            else if (aleatorio == 16)
            {
                
                player.SoundLocation = "i16.wav";
                player.Play();
            }
            else if (aleatorio == 17)
            {
                player.SoundLocation = "i17.wav";
                player.Play();
            }
            else if (aleatorio == 18)
            {
                player.SoundLocation = "i18.wav";
                player.Play();
            }
            else if (aleatorio == 19)
            {
                player.SoundLocation = "i19.wav";
                player.Play();
            }
            else if (aleatorio == 20)
            {
                player.SoundLocation = "i20.wav";
                player.Play();
            }
            else if (aleatorio == 21)
            {
                player.SoundLocation = "i21.wav";
                player.Play();
            }
            else if (aleatorio == 22)
            {
                player.SoundLocation = "i22.wav";
                player.Play();
            }
            else if (aleatorio == 23)
            {
                player.SoundLocation = "i23.wav";
                player.Play();
            }
            else if (aleatorio == 24)
            {
                player.SoundLocation = "i24.wav";
                player.Play();
            }
            if (aleatorio == 25)
            {
                player.SoundLocation = "i25.wav";
                player.Play();
            }
            else if (aleatorio == 26)
            {
                player.SoundLocation = "i26.wav";
                player.Play();
            }
            else if (aleatorio == 27)
            {
                player.SoundLocation = "i27.wav";
                player.Play();
            }
            else if (aleatorio == 28)
            {
                player.SoundLocation = "i28.wav";
                player.Play();
            }
            else if (aleatorio == 29)
            {
                player.SoundLocation = "i29.wav";
                player.Play();
            }
            else if (aleatorio == 30)
            {
                player.SoundLocation = "i30.wav";
                player.Play();
            }
            else if (aleatorio == 31)
            {
                player.SoundLocation = "n31.wav";
                player.Play();
            }
            else if (aleatorio == 32)
            {
                player.SoundLocation = "n32.wav";
                player.Play();
            }
            else if (aleatorio == 33)
            {
                player.SoundLocation = "n33.wav";
                player.Play();
            }
            else if (aleatorio == 34)
            {
                player.SoundLocation = "n34.wav";
                player.Play();
            }
            else if (aleatorio == 35)
            {
                player.SoundLocation = "n35.wav";
                player.Play();
            }
            else if (aleatorio == 36)
            {
                player.SoundLocation = "n36.wav";
                player.Play();
            }
            else if (aleatorio == 37)
            {
                player.SoundLocation = "n37.wav";
                player.Play();
            }
            else if (aleatorio == 38)
            {
                player.SoundLocation = "n38.wav";
                player.Play();
            }
            else if (aleatorio == 39)
            {
                player.SoundLocation = "n39.wav";
                player.Play();
            }
            else if (aleatorio == 40)
            {
                player.SoundLocation = "n40.wav";
                player.Play();
            }
            else if (aleatorio == 41)
            {
                player.SoundLocation = "n41.wav";
                player.Play();
            }
            else if (aleatorio == 42)
            {
                player.SoundLocation = "n42.wav";
                player.Play();
            }
            else if (aleatorio == 43)
            {
                player.SoundLocation = "n43.wav";
                player.Play();
            }
            else if (aleatorio == 44)
            {
                player.SoundLocation = "n44.wav";
                player.Play();
            }
            else if (aleatorio == 45)
            {
                player.SoundLocation = "n45.wav";
                player.Play();
            }
            else if (aleatorio == 46)
            {
                player.SoundLocation = "g46.wav";
                player.Play();
            }
            else if (aleatorio == 47)
            {
                player.SoundLocation = "g47.wav";
                player.Play();
            }
            else if (aleatorio == 48)
            {
                player.SoundLocation = "g48.wav";
                player.Play();
            }
            else if (aleatorio == 49)
            {
                player.SoundLocation = "g49.wav";
                player.Play();
            }
            else if (aleatorio == 50)
            {
                player.SoundLocation = "g50.wav";
                player.Play();
            }
            if (aleatorio == 51)
            {
                player.SoundLocation = "g51.wav";
                player.Play();
            }
            else if (aleatorio == 52)
            {
                player.SoundLocation = "g52.wav";
                player.Play();
            }
            else if (aleatorio == 53)
            {
                player.SoundLocation = "g53.wav";
                player.Play();
            }
            else if (aleatorio == 54)
            {
                player.SoundLocation = "g54.wav";
                player.Play();
            }
            else if (aleatorio == 55)
            {
                player.SoundLocation = "g55.wav";
                player.Play();
            }
            else if (aleatorio == 56)
            {
                player.SoundLocation = "g56.wav";
                player.Play();
            }
            else if (aleatorio == 57)
            {
                player.SoundLocation = "g57.wav";
                player.Play();
            }
            else if (aleatorio == 58)
            {
                player.SoundLocation = "g58.wav";
                player.Play();
            }
            else if (aleatorio == 59)
            {
                player.SoundLocation = "g59.wav";
                player.Play();
            }
            else if (aleatorio == 60)
            {
                player.SoundLocation = "g60.wav";
                player.Play();
            }
            else if (aleatorio == 61)
            {
                player.SoundLocation = "o61.wav";
                player.Play();
            }
            else if (aleatorio == 62)
            {
                player.SoundLocation = "o62.wav";
                player.Play();
            }
            else if (aleatorio == 63)
            {
                player.SoundLocation = "o63.wav";
                player.Play();
            }
            else if (aleatorio == 64)
            {
                player.SoundLocation = "o64.wav";
                player.Play();
            }
            else if (aleatorio == 65)
            {
                player.SoundLocation = "o65.wav";
                player.Play();
            }
            else if (aleatorio == 66)
            {
                player.SoundLocation = "o66.wav";
                player.Play();
            }
            else if (aleatorio == 67)
            {
                player.SoundLocation = "o67.wav";
                player.Play();
            }
            else if (aleatorio == 68)
            {
                player.SoundLocation = "o68.wav";
                player.Play();
            }
            else if (aleatorio == 69)
            {
                player.SoundLocation = "o69.wav";
                player.Play();
            }
            else if (aleatorio == 70)
            {
                player.SoundLocation = "o70.wav";
                player.Play();
            }
            else if (aleatorio == 71)
            {
                player.SoundLocation = "o71.wav";
                player.Play();
            }
            else if (aleatorio == 72)
            {
                player.SoundLocation = "o72.wav";
                player.Play();
            }
            else if (aleatorio == 73)
            {
                player.SoundLocation = "o73.wav";
                player.Play();
            }
            else if (aleatorio == 74)
            {
                player.SoundLocation = "o74.wav";
                player.Play();
            }
            else if(aleatorio == 75)
            {
                player.SoundLocation = "o75.wav";
                player.Play();
            }
        }
  
    }
}
