namespace XuanThuLab
{
    public class A{

    }

    public class B : A{

    }

    public class C : B {

    }

    // sử dụng sealed để niêm phong class không cho các lớp khác kế thừa
    // sealed : Animal{ 

    // }
    class Animal {
        public int legs {set; get;}

        public float weight {set; get;}

        public Animal(){
            Console.WriteLine("Khoi tao Animal");
        }
        public Animal(string name){
            Console.ForegroundColor =ConsoleColor.Red;
            Console.WriteLine($"Khoi tao Animal {name}");
            Console.ResetColor();

        }
        public void showLegs(){
            Console.WriteLine(this.legs);
        }
    }

    class Cat : Animal{
        public string food {set; get;}
        public string name {set; get;}
        // public Cat(){ // hàm khởi tạo này mặc định sẽ gọi hàm khởi tạo không tham số ở lớp cơ sở 
        //     this.legs = 4;
        //     this.weight = 25.2f;
        //     this.food = "fish";
        //     Console.WriteLine("Khoi tao Cat");
        // }
        //  public Cat() : base("balala"){ // hàm khởi tạo này sẽ gợi đến hàm khởi tạo có tham số ở lớp cở sở
        //     this.name = "fdbdfb";
        //     this.legs = 4;
        //     this.weight = 25.2f;
        //     this.food = "fish";
        //     Console.WriteLine("Khoi tao Cat");
        // }
         public Cat(string name) : base(name){ // hàm khởi tạo này sẽ gợi đến hàm khởi tạo có tham số ở lớp cở sở
            this.name = name;
            this.legs = 4;
            this.weight = 25.2f;
            this.food = "fish";
            Console.WriteLine("Khoi tao Cat");
        }
        public void eat(){
            Console.WriteLine(this.food);
        }
        //@overide trong java con  trong C# sử dụng từ khóa new 
        public new void showLegs(){
            Console.WriteLine($"Ghi đè phương thức: {this.legs}" );
        }
    }


    class Program{
        static  void Main(string[] args){
            Cat c = new Cat("balala");
            Console.WriteLine(c.food);
            c.showLegs();
            c.eat();

            //  A  -> B -> C
            //  A a = new A();
            //  B b = new B();
            //  C c = new C();
            //  a = b; được
            //  a = c; được
            //  b = c; được
            //  b = a; không được
            //  c = b; không được

        }
    }
}