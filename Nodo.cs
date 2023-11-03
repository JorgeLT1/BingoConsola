using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo1._0
{
    //class nodo
    internal class Nodo
    {
        //Atributo siguiente, y Tablero dato
       public Nodo siguiente;
       public Tablero dato;//El tipo de dato es tablero para utilizar los atributos de tablero y podernlo utilizar en la clase lista

        //inicializamos la clase
        public Nodo(Tablero dato)
        {

            siguiente = null;
            this.dato = dato;
        }
        public Nodo(Nodo siguiente, Tablero dato)
        {
            this.siguiente = siguiente;
            this.dato = dato;
        }
    }

   
}
