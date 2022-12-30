namespace XuanThuLab
{
    class Program{

        // <Access Modifiers> <return type> <name_menthod>(<parameters>){
        //     //statements
        // }
        //Access Modifiers : pham vi truy cap ( public | private | proteced)
    
        public static void Main(string[] args){
            hello(name: "Binh");// truyen tham so theo ten
            int x = 2;
            var a = CS09.tinhToan.tinhTich(1,4);
            var b = CS09.tinhToan.tinhTong(4,9);
            var c = CS09.tinhToan.tinhTong(4.99f,9.4f); //overloading 
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            Console.WriteLine($"{c}");
            CS09.tinhToan.binhPhuong(ref x); // tham chieu trong C# con trong C++ la int &x
            Console.WriteLine($"{x}"); //2 
        }
        public static void hello(string name = "An"){
            Console.WriteLine($"hello {name}");
        }
        // public static int tinhTich(int a, int b){
        //     return a*b;
        // }
    }
}