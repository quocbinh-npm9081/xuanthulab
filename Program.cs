namespace XuanThuLab
{
    //extenstion menthods
    static class Abc {
        public static void Print(this string s, ConsoleColor color){
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }
    }
    class Program{
        static void Main(string[] args){
            string s = "Xin Chao Cac Ban";
            s.Print(ConsoleColor.DarkBlue);
        }
    }
}