using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = "     Merhaba ben Merve, AcunMedya Akademide Genişletilmiş Yazılım Uzmanlığı Eğitimi alıyorum.      ";
            string sentence2 = "        Eğitimim 6 ay sürecek.       ";

            Console.WriteLine("Karakter uzunluğu:{0}", sentence1.Length);

            string sentences = string.Concat(sentence1, sentence2);
            Console.WriteLine("Concat ile birleştirilen cümleler :"+ sentences);


            string lowerCase = sentences.ToLower();
            Console.WriteLine("ToLower kullanımı:" + lowerCase);

            string upperCase = sentences.ToUpper();
            Console.WriteLine("ToUpper kullanımı:" + upperCase);

            Console.WriteLine("substring kullanımı : " + sentences.Substring(12));

            int firstsearch = sentences.IndexOf("e");
            Console.WriteLine("e harfi ilk kaçıncı indexte :" + firstsearch);

            int wantsearch = sentences.IndexOf("e",12);   //burda 12. imdexten sonra e harfine bakmaya başlıyor.
            Console.WriteLine("e harfi 12. indexten sonra ilk kaçıncı indexte :" + wantsearch);

            int lastsearch = sentences.LastIndexOf("e");
            Console.WriteLine("e harfi en son kaçıncı indexte :" + lastsearch);

            Console.WriteLine(sentence1.Contains(sentence2));  //sentence1 in içinde sentence2 varmı

            Console.WriteLine(sentence1.Contains("Merve"));

            Console.WriteLine("Cümle Merhaba ben merve ile başlıyor mu? " + sentence1.StartsWith("Merhaba ben Merve"));
            Console.WriteLine("Cümle 6 ay sürecek  ile bitiyor mu? " + sentence1.EndsWith("6 ay sürecek"));

            string newSentence1 = sentence1.Replace("Merve", "Elif").Replace("Merhaba", "Hello");
            Console.WriteLine(newSentence1);

            //split kullanımı 1. örnek
            string input1 = "Elma,Armut,Çilek,Karpuz";
            char[] delimiter1 = { ',' };
            string[] fruits1 = input1.Split(delimiter1);
            Console.WriteLine("Toplam meyve sayısı: " + fruits1.Length);

            //split kullanımı 2. örnek
            string input2 = "Elma,Armut,Çilek,Karpuz";
            char[] delimiter2 = { ',' };
            string[] fruits2 = input2.Split(delimiter2);

            foreach (string fruit2 in fruits2)
            {
                Console.WriteLine(fruit2);
            }

            //trim boşlukları siler
            Console.WriteLine(sentence1.Trim());
            Console.WriteLine(sentence2.TrimEnd());
            Console.WriteLine(sentence2.TrimStart());


            //format örnegi 
            string weather = "Güneşli";
            int degree = 26;

            string formattedText = string.Format("Bugun hava {0} ve  {1} derece.", weather,degree);

            Console.WriteLine(formattedText);


            //join örnegi
            string[] codelanguage = { "PHP", "HTML", "CSS", "JAVA", "C#" };
            string joincodelanguage = string.Join("--", codelanguage);
            Console.WriteLine("Birleştirilmiş kod dilleri :" + joincodelanguage);











            Console.ReadLine();
        }
    }
}
