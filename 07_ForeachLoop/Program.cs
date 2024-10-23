using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Froeach Döngüsü

            //Foreach(1;2;3;4)

            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //---------------------------------------------------

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //---------------------------------------------------

            //int[] numbers = { 45, 85, 965, 415, 3646, 44, 4, 54, 46, 46, 4, 48, 78, 56, 4, 6, 16, 1, 6464641 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //---------------------------------------------------

            //int[] numbers = { 45, 85, 965, 415, 3646, 44, 4, 54, 46, 46, 4, 48, 78, 56, 4, 6, 16, 1, 6464641 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //---------------------------------------------------

            //int[] numbers = { 45, 85, 965, 415, 3646, 44, 4, 54, 46, 46, 4, 48, 78, 56, 4, 6, 16, 1, 644641 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number; // total = number + total;
            //}

            //Console.WriteLine(total);

            //---------------------------------------------------

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //---------------------------------------------------

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion


            #region  Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine("\n\n\n");


            // Kullanıcıdan sınıftaki öğrenci sayısını alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            // Öğrenci isimlerini ve not ortalamarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvarege = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencisin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;// notları topluyoruz.
                }
                Console.WriteLine();

                studentExamAvarege[i] = totalExamResult / 3;
            }

            // Sınav ortalamarı

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvarege[i]}");

                // Öğrencinin ortalaması ve geçip kalma durumları
                if (studentExamAvarege[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti.");
                }
                else 
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");

                }
                Console.WriteLine("------------------------------");

            }






            #endregion

            Console.Read();

        }
    }
}
