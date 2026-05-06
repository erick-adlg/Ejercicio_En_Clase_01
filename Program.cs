using Ejercicio_En_Clase_01;
using System;
class Program
{
    static void Main()
    {
        Area autos = new Area("Auto", 30, 5, 10);

        Area motos = new Area("Motocicleta", 20, 3, 5);

        Area pesados = new Area("Vehículo Pesado", 10, 2, 15);

        int opcion;

        do

        {
            Console.Clear();

            Console.WriteLine("1. Ingresar Auto");
            Console.WriteLine("2. Ingresar Motocicleta");
            Console.WriteLine("3. Ingresar Vehículo Pesado");
            Console.WriteLine("4. Retirar Auto");
            Console.WriteLine("5. Retirar Motocicleta");
            Console.WriteLine("6. Retirar Vehículo Pesado");
            Console.WriteLine("7. Ver estado");
            Console.WriteLine("8. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    autos.IngresarVehiculo();
                    break;

                case 2:
                    motos.IngresarVehiculo();
                    break;

                case 3:
                    pesados.IngresarVehiculo();
                    break;

                case 4:
                    autos.RetirarVehiculo();
                    break;

                case 5:
                    motos.RetirarVehiculo();
                    break;

                case 6:
                    pesados.RetirarVehiculo();
                    break;

                case 7:
                    autos.MostrarEstado();
                    motos.MostrarEstado();
                    pesados.MostrarEstado();
                    break;

                case 8:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        

        } while (opcion != 8);
    }
}