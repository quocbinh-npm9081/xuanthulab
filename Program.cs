using System;
using System.Linq;
// using Linq;Linq là một query language được dùng để truy vấn dữ liệu từ các nguồn dữ liệu khác nhau (data sources).
namespace XuanThuLab
{
    class Program{

        //Anonymos - Kieu du lieu vo danh
        // Giống như Object trong Javascript cũng có cặp key và value nhưng nó chỉ cho phép đọc chứ không được phép sửa xóa
        // 
        //syntax new {thuocTinh = giatri, thuoctinh2 = giatri2} 
        class SinhVien{
            public string hoTen{set;get;} 
            public int namSinh{set; get;}
            public string noiSinh{set; get;}
        }
        static void PrintInfoDynamic(dynamic objdy){
            //dynamic la` kiểu dữ liệu động linh hoạt, không cần quan tâm là thuộc tính có tồn tại hay không( nó giống như sử dủng javscript thuần vậy)
            //dynamic không chạy khi biên dịch, nó chỉ chạy khi thực thi
            // dotnet run là thực thi
            // dotnet build là biên dịch
            Console.WriteLine($"dymaic info {objdy.ten}");
        }
        static  void Main(string[] args){
            var sanpham = new {
                Ten = "Iphone8",
                Gia = 100,
                NamSx = 2018
            };
            Console.WriteLine($"Ten san pham: {sanpham.Ten}");
            List<SinhVien> cacSinhVien = new List<SinhVien>(){
                new SinhVien(){hoTen = "Binh",namSinh = 2001, noiSinh = "Khanh Hoa"},
                new SinhVien(){hoTen = "An",namSinh = 2010, noiSinh = "Nghe An"},
                new SinhVien(){hoTen = "Uyen",namSinh = 2006, noiSinh = "Nha Trang"},
            };

            // Query Linq
            var ketQua = from sv in cacSinhVien
                        where sv.namSinh <= 2006
                        select new {
                        ten = sv.hoTen,
                        namSinh = sv.namSinh
                        };
            foreach (var sv in ketQua)
            {
                Console.WriteLine($"ten: {sv.ten} - namsinh: {sv.namSinh}");
            }
           
        }
    }
}