using myNameSpace;
using myNameSpace.childrenNameSpace;
using SanPham;
//Nạp phươn thức tĩnh để khởi mất công khai báo 
using static System.Console;
namespace XuanThuLab
{
    class Program{
        static  void Main(string[] args){
            Class1.xinChao();
            Class1Chilren.xinChao();
            WriteLine("Khong can goi Console"); //không cần Console.WriteLine()
            Product sanPham1 = new Product("samSung", "dien thoai sam sung vcl");
            sanPham1.price = 1000;
            WriteLine(sanPham1.getInfo()); 

        }
    }
}