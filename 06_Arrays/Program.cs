using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe"};

            //for (int i = 0; i < colors.Length; i++) { 

            //    Console.WriteLine(colors[i]);

            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1120, 76891, 21231};

            //for (int i = 0; i < numbers.Length; i++) {

            //    if (numbers[i] % 3 ==0)
            //    {

            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //char[] symbols = { 'a', 'c', 'b', 'd', '0', '*', '-' };

            //for (int i = 0; i < symbols.Length; i++) { 
            //Console.Write(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 1251, 215912, 86, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++) {

            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine("En büyük SAYI : " + maxNumber);


            //string[] persons = { "Ali", "Ayşe", "Ahmet", "Buse", "Cem", "Osman", "Lale"};
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 1, 0, 3, 5590, 2, 125412, 11, 8, 9 };  
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) { 
            //Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotları

            //string[] people = { "ali", "Buse", "Ayşe", "murat", "Kaya", "oSMAN" };

            //int index = Array.IndexOf(people,"oSMAN");
            //Console.WriteLine(index);



            #endregion

            #region Kullanıcıdan Değer Alma 

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++) 
            //{ 
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("******************************");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, 70 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)

            //{ 
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 1124, 2221, 112, 291, 9601, 21, 215, 99, 110, 125, 1201, 220, 22, 5,4,2,0,10 };

            Console.WriteLine("Çift Sayılar: ");

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 ==0)
                {
                    Console.WriteLine(numbers[i]);  
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------ ");
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar: ");
            for (int i = 0; i < numbers.Length; i++)
            { 
                if(numbers[i] % 2 ==1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }    
            #endregion

            Console.Read();

        }
    }
}
