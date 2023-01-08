using System;
namespace XuanThuLab
{
    //Lap trinh huong su kien
    //publisher -> class -> phát sự kiện
    //subscriber -> class -> nhận sự kiện
    public delegate void SuKienNhapSo(int x);
    //publisher 
    class DuLieuNhap : EventArgs{
        public int data {set; get;}
        public DuLieuNhap(int x){
            data = x;
        }
    }
    class UserInput {
      //  public event SuKienNhapSo enterEvent;
        public event EventHandler enterEvent; // <=> delegate void event Kieu(object? senderm EventArgs args)
        public void input(){       
            do
            {
                Console.WriteLine("Nhap so nguyen");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                //Phat su kien
                enterEvent?.Invoke(this, new DuLieuNhap(i));
            } while (true);
        }
    }
    //subscriber
    class TinhCan{
      
        public void can(object sender,EventArgs i){
            DuLieuNhap x = (DuLieuNhap)i;
            int z = x.data;
            Console.WriteLine($"Can bac hai cua {z} la {Math.Sqrt(z)}");
        }
        public void subTinhCan(UserInput input){
            input.enterEvent += can;
        }
    }
    class TinhBinhPhuong{
        public void tinhBinhPhuong(object sender,EventArgs  i){
            DuLieuNhap x = (DuLieuNhap)i;
            int z = x.data;
            Console.WriteLine($"Binh phuong cua {z} la {z*z}");
        }
        public void subTinhBinhPhuong(UserInput input){
            input.enterEvent += tinhBinhPhuong;
        }
    }
    class Program{
        static void Main(string[] args){
            UserInput userEnterInput = new UserInput();
            TinhCan tinhCan = new TinhCan();
            TinhBinhPhuong tinhBinhPhuong = new TinhBinhPhuong(); 

            tinhBinhPhuong.subTinhBinhPhuong(userEnterInput);
            tinhCan.subTinhCan(userEnterInput);

            //bắt sự kiện nút crt+C
            Console.CancelKeyPress += (sender, e)=>{
                Console.WriteLine();
                Console.WriteLine("Thoat ung dung");
            };

            userEnterInput.input();            
        }
    }
}