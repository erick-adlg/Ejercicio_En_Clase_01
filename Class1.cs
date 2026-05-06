using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_En_Clase_01
{
    internal class Vehiculo 
    {
        //Atributos 
        public string tipo;
        public string placa;
        public int horas;

        //Cosntructor 
        public Vehiculo(string t, string p, int h)
        {
            tipo = t;
            placa = p;
            horas = h;
        }
    }
}
