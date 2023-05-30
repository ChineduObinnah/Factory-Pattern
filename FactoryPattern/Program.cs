namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" How many tires do you want your vehicle to have? 4 or 6?");
          var response =  Console.ReadLine();
             
            var intance = VehicleFactory.GetVehicle(response);
            intance.Drive();
        }
    }
}
