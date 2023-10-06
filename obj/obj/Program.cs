using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car corolla = new Car("pembe", 600, 1996, "corolla");
            Car mercedes = new Car("sarı", 1000, 2015, "merdeces");

            Console.WriteLine(corolla.Color);
            Console.WriteLine(corolla.MaxSpeed);
            Console.WriteLine(corolla.Modelyear);


            Console.WriteLine(mercedes.Color);
            Console.WriteLine(mercedes.MaxSpeed);
            Console.WriteLine(mercedes.Modelyear);

            corolla.CurrentSpeed = 170;          //set
            mercedes.CurrentSpeed = 280;

            corolla.isSpeedLimit();
            mercedes.isSpeedLimit();

            corolla.MaxSpeed = 750;
            corolla.MaxSpeed = 1000;

            corolla.VehicleIdentificationNumber = "85558954";
            mercedes.VehicleIdentificationNumber = "548754654554128";
           
                Console.WriteLine(corolla.VehicleIdentificationNumber);  
                Console.WriteLine(mercedes.VehicleIdentificationNumber);

            Supercar supercar = new Supercar("kırmızı", 650, 2023, "bmw",25);
            Console.WriteLine(supercar.MaxSpeed);


            Console.ReadLine();
        }


    }

}
