using System.Text;

namespace XuanThuLab
{
    //http://gyanendushekhar.com/2016/05/01/string-and-stringbuilder-csharp/
    class Program{
        static void Main(string[] args){
            string thongbao1; // <== viet cach nay se khong toi ua bi nho  vi string luu tren heap  no se lien tuc tao doi tuong roi gan lai value
            thongbao1 = "xin";
            thongbao1 = "Cac ban";

            StringBuilder thongao2 = new StringBuilder(); //<== stringBuilder chi lam viec voi 1 doi tuong duy nhat
            thongao2.Append("Xin");
            thongao2.Append("Chao cac banj");

        }
    }
}