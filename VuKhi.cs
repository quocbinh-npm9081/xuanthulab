using System;
namespace CS10
{
    class VuKhi {  //khong khai bao access modifiers thi default la` internal
        //Du lieu
        public string name; // default private
        public int damage = 0;
        public string noiSanXuat {set; get;}



        public VuKhi(string name, int damage, string noiSanXuat = "VIet nam"){
            this.name = name;
            this.damage = damage;
            this.noiSanXuat = noiSanXuat;
            Console.WriteLine($"Ten sung {this.name}");
        }
        public void attack(){
            for (int i = 0; i < this.damage; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        public int satThuong{
            set {   
                this.damage = value;
            }
            get{
                return this.damage;
            }
        }
        ~VuKhi(){ // func destroy
            Console.ForegroundColor = ConsoleColor.Red; // hien dong nay mau do
            Console.WriteLine($"Huy + {this.name}");
            Console.ResetColor();//tra lai mau ban dau
        }
    }
}