namespace GestorVehiculos
{
    class Program
    {
        private static void Main(string[] args)
        {
            Vehiculo miAuto = new Vehiculo("Toyota", "Corolla");
            Vehiculo miMoto = new Vehiculo("Yamaha", "R6");

            miAuto.MostrarInfo();
            miMoto.MostrarInfo();

            Console.ReadKey();

        }
    }
}