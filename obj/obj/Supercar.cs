using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Supercar : Car    // supercar sınıfı car sınıfına kalıtım alır. aşagıdaki de consructor metotdur.
    {
        public Supercar(string color, int maxSpeed, int modelYear, string modelName, int NosCount) : base(color, maxSpeed, modelYear, modelName)  //base hangi sınıftan kalıtım alıyorsaN onları yaz 
        {

            Console.WriteLine(NosCount);
        }
    }
}
