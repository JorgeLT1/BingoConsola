using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo1._0
{
    internal class Tablero//clase tablero
    {
        //Atributos 2 arreglos, uno bidimensional y un unidimensional de tipo string para almacenar los nombres
        public int[,] tabla;
        public string [] nombre;

        //constructor Tablero para inicializar la clase
        public Tablero(int[,] tabla, string [] nombre)
        {
            this.tabla = tabla;
            this.tabla = new int[5, 5];//Aqui esta el tablero 5x5 que le pasamos por parametro en el main
            this.nombre = nombre;// de igual forma el nombre
        }
        public void tablero()
        {
            Random ran = new Random();// aqui creamos un ramdon para que genere los numeros aleatorios
            
            int aleatorio;//aqui creamos una variable aleatoria para almacenar los numeros aleatorios
            
            //aqui hacemos una funcion cuadratica para llenar el arreglo bidimencional
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (j == 0)// este if va a ir llenando de manera aleatoria las posiciones del arreglo
                    {
                        do//creamos un do while para que verifique en el metodo verificar si el numero aleatorio esta repetido, si esta repetido se va a ejecutar otra vez, si no esta repetido va a seguir llenando la siguiente pos.
                        {
                            aleatorio = ran.Next(1, 15+1);// aqui estamos generando el numero aleatorio y almacenandolo en la variable aleatorio.
                        } while (Verificar(aleatorio) == true);
                        tabla[i, j] = aleatorio;//Estamos llenando el arreglo bidimencional con la variable aleatoria
                    }
                    
                    else if (j == 1)
                    {
                        do
                        {
                            aleatorio = ran.Next(16, 30 + 1);
                        } while (Verificar(aleatorio) == true);
                        tabla[i, j] = aleatorio;
                    }
                    else if (j == 2)
                    {
                        do
                        {
                            aleatorio = ran.Next(31, 45 + 1);
                        } while (Verificar(aleatorio) == true);
                        tabla[i, j] = aleatorio;
                    }
                    else if (j == 3)
                    {
                        do
                        {
                            aleatorio = ran.Next(46, 60 + 1);
                        } while (Verificar(aleatorio) == true);
                        tabla[i, j] = aleatorio;
                    }
                    else if (j == 4)
                    {
                        do
                        {
                            aleatorio = ran.Next(61, 75 + 1);
                        } while (Verificar(aleatorio) == true);
                        tabla[i, j] = aleatorio;
                    }

                }
            }
            tabla[2, 2] = 0;

        }
        public bool Verificar(int num)//Esta funcion verifica si el numero esta repetido
        {
            
            //Recorremos el arreglo  
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (num == tabla[i,j])//Cuando num(aletario) sea igual al arreglo bidimencional va a retornar true, es decir va a volver hacer el do while para genenrar otro numero que no sea igual
                    {
                        return true;
                    }
                }
            }

            return false;//retorna falso cuando no son iguales

        }

    }
}
