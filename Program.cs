using System;
using System.Linq;
using System.Reflection;
namespace XuanThuLab
{
    class Program{
        // trong js thì mình có thể console để xem tất cả thông tin như name ,properties, attribute, method, value
        // nhưng trong c# thì vãi cái lồn, phải truy cấp thông qua các method GetType -> Get
     
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method |AttributeTargets.Property)] // MotaAttribute được sử dụng ở đâu
        class MotaAttribute : Attribute{
            public string ThongBao {set; get;}
            public MotaAttribute(string _thongBao){
                this.ThongBao = _thongBao;
            }
        }
        [Mota("Lop chua thong tin ve user")]
        class User {
            [Mota("Ten nguoi dung")]
            public string name {set; get;}
            
            [Mota("Tuoi nguoi dung")]
            public int age {set; get;}
            public User(string _name, int _age){
                this.name = _name;
                this.age = _age;
            }
            public void PrintInfo() => Console.WriteLine(age);

        }

        static void Main(string[] args){
            // int[] a = {1,2,3,4,5,6};
            // Type typea = a.GetType();
            // Console.WriteLine(typea);
            // Console.WriteLine("====get property====");
            // typea.GetProperties().ToList().ForEach(
            //     (PropertyInfo a)=>{
            //     Console.WriteLine(a.Name);
            // });
            // Console.WriteLine("====get fields====");
            // typea.GetFields().ToList().ForEach(
            //     (FieldInfo a) => {
            //     Console.WriteLine(a.Name);
            // });
            // Console.WriteLine("====get menthods====");
            // typea.GetMethods().ToList().ForEach(
            //     (MethodInfo c) => {
            //     Console.WriteLine(c.Name);
            // });

            User binh = new User("binh", 2001);
            binh.PrintInfo();
            Console.WriteLine("========= Lay property =========");
            var properties = binh.GetType().GetProperties();
            foreach (PropertyInfo p in properties)
            {
                Console.WriteLine(p.Name);
                var attributies = p.GetCustomAttributes(false);
                foreach (MotaAttribute attr in attributies)
                {
                    if(attr != null){
                        var value = p.GetValue(binh);
                        var name = p.Name;
                        Console.WriteLine($"{name}- {attr.ThongBao} :{value}");

                    }
                }
            }
          
        
        }
    }
}