using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_En_Clase_01
{
    internal class Area 
    {
        //Atributos
        public string nombre;
        public int capacidad;
        public int ocupados;
        public double precioHora;

        //Constructor 
        public Area (string n, int c, int o, double pH)
        {
            nombre = n;
            capacidad = c;
            ocupados = o;
            precioHora = pH;
        }
        //Metodos 
        public void MostrarEstado()
        {
            Console.WriteLine("Area" + nombre);
            Console.WriteLine("Capacidad Maxima: " + capacidad);
            Console.WriteLine("Espacios Ocupados: " + ocupados);
            Console.WriteLine("Espacios disponibles" + (capacidad - ocupados));
        }

        public void IngresarVehiculo()
        {
            if (ocupados < capacidad)
            {
                Console.Write("Ingrese placa: ");
                string placa = Console.ReadLine();

                Console.Write("Ingrese horas estimadas: ");
                int horas = Convert.ToInt32(Console.ReadLine());

                // CREAR OBJETO VEHÍCULO
                Vehiculo v = new Vehiculo(placa, nombre, horas);

                ocupados++;

                Console.WriteLine("\nVehículo ingresado.");
                Console.WriteLine("Placa: " + v.placa);
                Console.WriteLine("Tipo: " + v.tipo);

                double total = v.horas * precioHora;

                Console.WriteLine("Total a pagar: Q" + total);
            }
            else
            {
                Console.WriteLine("Área llena.");
            }
        }

        public void RetirarVehiculo()
        {
            if (ocupados > 0)
            {
                Console.Write("Ingrese placa del vehículo a retirar: ");
                string placa = Console.ReadLine();

                ocupados--;

                Console.WriteLine("\nVehículo retirado correctamente.");
                Console.WriteLine("Placa retirada: " + placa);
                Console.WriteLine("Área: " + nombre);
                Console.WriteLine("Espacios ocupados ahora: " + ocupados);
                Console.WriteLine("Espacios disponibles ahora: " + (capacidad - ocupados));
            }
            else
            {
                Console.WriteLine("No hay vehículos para retirar en esta área.");
            }
        }
    }

}

