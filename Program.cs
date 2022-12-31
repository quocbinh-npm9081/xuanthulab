using CS16;
namespace XuanThuLab
{
    //generic giúp ta đỡ phải viết nhiều memthods overider
    class Program{
        static void swap<T>(ref T a,ref T b){
            T t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args){
            int a = 5;
            int b = 45;
            string x = "11";
            string y = "27";
            swap(ref a,ref b);
            swap(ref x,ref y); 
            Console.WriteLine($"so a = {a}, so b = {b}");
            Console.WriteLine($"so x = {x}, so y = {y}");
            Product<int> nokia_number_id = new Product<int>(1);
            Product<string> noki_string_id = new Product<string>("Dh5190");
            nokia_number_id.PrintInfo();
            noki_string_id.PrintInfo();
        }
    }
}