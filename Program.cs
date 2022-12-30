using System;
namespace XuanThuLab
{
    class Program{
        static void Main(string[] args){
            string name;
            char kitu;
            kitu = 'a'; // ki tu de trong ngoac don
            name = "binh"; // chuoi de trong ngoac kep
            string age = "binh";
            if(age == name) {
                Console.WriteLine("Bang nhau");
            }else{
               Console.WriteLine("Ko Bang nhau");
            }
            const double PI = 3.14; // constants
            Console.WriteLine("Dy laf Hang so PI : {0}", PI);
            float soFloat;
            soFloat = 12.12f;
            object student;
            student = name;
            Console.Title ="Vi du ve doi tuong COnsole";
            Console.WriteLine("name : {0}", name);
            Console.WriteLine("soFloat : {0}", soFloat);
            Console.WriteLine("student : {0}", student);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("soFloat : {0}", soFloat);
            Console.Write("Vui long Nhan phim Enter");
            if ( Console.ReadKey().Key == ConsoleKey.Enter)
            {
            Console.Write("Vui long nhap ten cua ban");
            string? hovaten;
            hovaten = Console.ReadLine();
            Console.WriteLine($"xin chao {hovaten}");
            }

          
          //  Console.Clear();
        }
    }
}