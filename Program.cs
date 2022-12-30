namespace XuanThuLab
{
    class Program{
        //SỰ KHÁC BIỆT CỦA STRUC LÀ THAM TRỊ - CÒN CLASS LÀ THAM CHIẾU
        public struct Product{ // struct la tham tri ( luu o stack)

            //du lieu
            public string name;
            public double price {set;get;}
            
            //phuong thuoc
            public string getInfo(){
                return $"Ten san pham: {name} - gia: {price}";
            }
            //ham tao
            public Product(string _name, double _price){
                this.name= _name;
                this.price = _price;
            }           
        }
          // ENUM
        //PHÂN LOẠI HỌC LỰC
        enum TYPEHOCLUC {Kem, TrungBinh, Kha, Gioi}
    
        static  void Main(string[] args){      


  
          
            Product sanpham1 = new Product("samsung", 1000);
            Product sanpham2 = new Product("samsung", 1000);
            if(sanpham1.Equals(sanpham2)){
                Console.WriteLine("stsanpham1 Bang sanpham2");
            }else{
                Console.WriteLine("stsanpham1 Khong bang sanpham2");

            }
            Console.WriteLine(sanpham1.getInfo());
            Console.WriteLine(sanpham1.price);
            TYPEHOCLUC hocluc;
            hocluc = TYPEHOCLUC.Kha; 
            int soHocLuc = (int)hocluc; // tim index trong enum
            Console.WriteLine(soHocLuc);
            switch (hocluc)
            {
                case TYPEHOCLUC.Kem :
                Console.WriteLine("Hoc luc Kem");
                break;
                case TYPEHOCLUC.Kha :
                Console.WriteLine("Hoc luc Kha");
                break;
                case TYPEHOCLUC.TrungBinh :
                Console.WriteLine("Hoc luc TrungBinh");
                break;
                case TYPEHOCLUC.Gioi :
                Console.WriteLine("Hoc luc Gioi");
                break;
                default:
                    return;
            }

        }
    }
}