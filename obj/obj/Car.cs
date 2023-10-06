using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {

        // public her yerden erişilebilmesi için tanımlanan genel bir erişim belirtecidir.
        
        private string color;  //sınıf içinde kullanılacak değişkenler belirlendi ve kapsüllemek(get-set) için private kulllanıldı.(private= başka sınıf içerisinden ulaşılamasın sadce car sınıfından ulaşılsın.
        private int maxSpeed;
        private int modelyear;
        private int currentSpeed;
        private string carBrand;
        private string vehicleIdentificationNumber;          //CTR +R CTRL +E 

        public string Color   // property                        //başka bir sınıftan değişkene değer atamak yada onu ekrana yazdırabilmek için get-set çagrılır.
        {
            get { return color; }   // get method  //degişkeni döndürür
            set { color = value; }  // set method   //değişkene değer atar
        }

        public int MaxSpeed   // property
        {
            get { return maxSpeed; }   // get method
            set
            {
                if (maxSpeed > 500)
                {
                    Console.WriteLine("Abartma");
                   }
                else
                {
                    maxSpeed = value;
                }

            }  // set method
        }

        public int Modelyear   // property
        {
            get { return modelyear; }   // get method
            set { modelyear = value; }  // set method
        }

        public int CurrentSpeed   // property
        {
            get { return currentSpeed; }   // get method
            set { currentSpeed = value; }  // set method
        }

        public string CarBrand   // property
        {
            get { return carBrand; }   // get method
            set { carBrand = value; }  // set method
        }


        public string VehicleIdentificationNumber  // property
        {
            //aracın şase numarasını herkesle paylaşmak istemiyoruz o yüzden get öxelligini şifreledik. "get { return vehicleIdentificationNumber; }   // get method"
   
            set {
                if (value.Length != 15) {
                    Console.WriteLine("Şase numarası 15 haneden az olamaz.");
                }
                else
                {
                    vehicleIdentificationNumber = value;
                }

            }
            get
            {
                try     
                {
                    String vehicleIdentificationPrivateNo = "***********";

                    //return vehicleIdentificationPrivateNo
                    //    + vehicleIdentificationNumber[11]
                    //    + vehicleIdentificationNumber[12]
                    //    + vehicleIdentificationNumber[13]
                    //    + vehicleIdentificationNumber[14];

                    return vehicleIdentificationPrivateNo + vehicleIdentificationNumber.Substring(11);
                }
                catch (Exception m)
                {
                    Console.WriteLine("saşe numarası okunurken hata oluştu." + m.Message);
                    return null;
                   
                }
                

            }
        }

        public Car(string color, int maxSpeed, int modelyear, string carBrand)    //consructor metodu yazılmıştır.Bu metot oluşturacagımız nesnelerin hangi özelliklere sahip olduguna belirlememize yardımcı olıur. 
        {
            this.Color = color;
            this.MaxSpeed = maxSpeed;
            this.Modelyear = modelyear;
            this.CarBrand = carBrand;

        }

        public void isSpeedLimit()
        {
            if (currentSpeed > 180)
            {
                Console.WriteLine(carBrand + "  Çok hızlısın yavaşla!");
            }
            else
            {
                Console.WriteLine(carBrand + "  Normal Hız.");
            }
        }

        public void fullThrottle()   // method çagırınca b u yazıyı verşyor
        {
            Console.WriteLine("The car is going as fast as it can!");
        }


        


    }
}