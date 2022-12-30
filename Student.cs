using System;

namespace CS10a1
{
    //IDisposable la interface giup ta auto destroy
    class Student : IDisposable{
        public string name {set; get;}
        public Student(string name){
            this.name = name;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Khoi tao Student");
            Console.ResetColor();
        }
        public void Dispose(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dispose" + this.name);
            Console.ResetColor();
        }

    }
}