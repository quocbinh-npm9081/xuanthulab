using CS10;
using CS10a1;

namespace XuanThuLab
{
    public class Program{       
        static void DisposeAll (){
            using Student sv = new Student("SV");
        }

        static void Main(string[] args){
            // VuKhi ak47 = new VuKhi("ak47", 5);
            // Console.WriteLine($"sung: {ak47.name} - damge: {ak47.damage} - noi san xuat: {ak47.noiSanXuat}");
            // ak47.attack();
            // ak47.satThuong = 10;
            // ak47.noiSanXuat = "USA";
            // Console.WriteLine($"sung: {ak47.name} - damge: {ak47.damage} - noi san xuat: {ak47.noiSanXuat}");
            // ak47.attack();
            // ak47 = null; //destroy 
            // for (int i = 0; i < 100000; i++)
            // {
            //     VuKhi ak47;
            //     ak47 = new VuKhi("ak47" + i, 5);
            //     ak47 = null; // huy tham chieu
      
            // }
            // GC.Collect(); // khi >net core het bo nho, no se chay ham huy, huy cac doi tuong khong co tham chieu
            // using (Student s = new Student("Sinh vien")){
            //     //statements
            // }
            DisposeAll();
        }
    }
}