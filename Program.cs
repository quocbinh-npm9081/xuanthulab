using System.Linq; // thu vien mo rong cho mang, giong Math() trong javascript
namespace XuanThuLab
{
    //array
    class Program{
        static  void Main(string[] args){
        
          //  Console.BackgroundColor = ConsoleColor.Cyan;

            string[] students = new string[3];
       
            students[0] = "binh";
            students[1] = "binh";
            students[2] = "binh";
           
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Danh sach student: {students[i]}");
            }
          
            int[] numbers = new int[3]{1,2,3};
          
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Danh sach numbers: {numbers[i]}");
            }

            // su dung thu vien Linq lay gia tri Min cua array numbers
            Console.WriteLine($"gia tri nho nhat la: {numbers.Min()}");
            Console.WriteLine($"gia tri tong cac phan tu:  {numbers.Sum()}");
           
            //forEach 
            foreach (var item in numbers)
            {
                Console.WriteLine($"Danh sach numbers as foreach: {item}");
            }

            // MANG 2 CHIEU( MA TRAN)
            //     0 1 2
            // 0   2 3 4.5
            // 1   1 9 8            
            double[,] numbersMatrix= new double[2,3] {{2,3, 4.5}, {1,9,8}};
            Console.WriteLine($"Gia tri lai hang 1 cot 2: {numbersMatrix[0,1]}");
            Console.WriteLine("---");
            // duyet ma tra
            for(int i = 0 ; i < 2; i++){ //duyet hang
                for(int j = 0 ; j < 3; j++){//duyet cot
                    Console.Write($"| {numbersMatrix[i,j]} | " );
                }
                Console.WriteLine();
            }

        }
    }
}