using System;
using System.Linq;
namespace XuanThuLab
{
    //Linq ( Language Integreted Query) - Ngôn ngữ truy vấn tích hợp
    //Linq chuyên giùm để truy vấn đến tất cả các nguồn dữ liệu:    1) IEnumerable, IEnumerable<T>(Array, List, Stack, Queue, ...)
    //                                                              2) XML
    //                                                              3) SQL
    public class Product
    {
        public int ID {set; get;}
        public string Name {set; get;}         // tên
        public double Price {set; get;}        // giá
        public string[] Colors {set; get;}     // các màu sắc
        public int Brand {set; get;}           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
        => $"{ID,3} {Name, 12} {Price, 5} {Brand, 2} {string.Join(",", Colors)}";

    }
    public class  Brand {
        public string Name {set; get;}
        public int ID {set; get;}
    }
    class Program{
        static void Main(string[] args){
      
            //danh sach cac cong ty
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };
            //danh sach cac san pham
            var products = new List<Product>(){
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };
            var prductPrice400 = from p in products 
                                 where p.Price == 400
                                 select p;
            foreach(Product p in prductPrice400){
                Console.WriteLine(p);
            }
        }
    }
}