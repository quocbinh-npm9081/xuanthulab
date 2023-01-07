//biểu thức Lamda có nghĩa là anonimos function( phương thức không tên)
using System;
using System.Linq;
namespace XuanThuLab
{
    class Program{
        static void Main(string[] args){
            Action<string> thongbao=(string s)=> Console.WriteLine(s); // Action<string> thongbao  <=> delegate void thongbao(string s);
            thongbao.Invoke("Xin chao Lamda");
            int[] numbers = {1,2,3,4,5,6};
            var result = numbers.Select(
                (int x) => {
                    return x+1;
                }
            );
            foreach(var kq in result){
                Console.WriteLine(kq);
            }
        }
    }
}