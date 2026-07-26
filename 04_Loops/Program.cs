using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;

            //for (i=1; i<=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}


            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adresi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++) { 

            //Console.WriteLine("Yaşasın Cumhuriyet");   

            //}





            #endregion

            #region For Döngüsü ile Karar Yapıları 

            //for (int i = 1; i <= 100; i++) { 

            //    if (i % 5 == 0 )
            //    {
            //        Console.WriteLine(i);
            //    }

            //}


            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++) { 

            //    totalValue += i;   
            //}
            //Console.WriteLine(totalValue);


            #endregion


            #region While Döngüsü 

            int i = 1;
            while (i <=10 ) {

                    Console.WriteLine(i);
                i++;
            }


            #endregion


            #region Örnek Sınav Sorusu
            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            Console.Write("Sayı girin: ");
            int number = int.Parse( Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100; //4.56 --> 4

            Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            sum = ones + tens + hundreds;
            Console.WriteLine(sum); 

            #endregion
            Console.Read();
        }
    }
}
