using System;
using System.Threading;
using System.Threading.Tasks;
namespace XuanThuLab
{
    //async await
    class Program{
        static void DoSomeThing(int seconds, string msg){
            for (int i = 0; i < seconds; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"------{msg}");
                Console.ResetColor();
                Thread.Sleep(1000);

            }
            Console.WriteLine($"-----END");
        }

        static async Task Task1(){
              Task t1 = new Task(()=>  DoSomeThing(5, "wait...")); // Action <=> ()=> {}
              t1.Start();
             // t1.Wait();
             await t1;
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("Tag 1 hoan thanh");
              Console.ResetColor();
           //   return t1;

        }
        static async Task Task2(){
            Task t2 = new Task((object obj)=> {
                            string tenTacVu = (string)obj;
                            DoSomeThing(5, tenTacVu);
                        }, "async"); // Action <=> ()=> {}    
            t2.Start();
            //t2.Wait();
            await t2; //<=>return t2;        
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("Tag 2 hoan thanh");
              Console.ResetColor();
          //  return t2;          
        }

        static Task<string> Task3(){
             Task<string>? t3 = new Task<string>(
                ()=> {
                    DoSomeThing(3, "t3");
                    return "Return form t3";
                }
            );
            t3.Start();

              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("Tag 3 hoan thanh");
              Console.ResetColor();
           return t3;          
        }
        static Task<string> Task4(){
            Task<string> t4 =new Task<string>(
                (object obj)=> {
                    string t = (String)obj;
                    DoSomeThing(5, t);
                    return "Return form t4";
                }, "t4");
            t4.Start();

              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("Tag 4 hoan thanh");
              Console.ResetColor();
            return t4;          
        }
     
        static  void Main(string[] args){
            Task t1 = Task1();
            Task t2 = Task2();
            Task<string> t3 = Task3();
            Task<string> t4 = Task4();
           // t2.Wait(); // t2 hoàng thành thì mới cho chạy tiếp
         
            Task.WaitAll(t3,t4);
            Console.WriteLine($"Gia tri tra ve {t4.Result}");
            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
    }
}