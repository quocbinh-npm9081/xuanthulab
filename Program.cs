namespace XuanThuLab
{
    //delegate <== kiểu dữ liệu ủy quyền ( giống con trỏ trong C++) nhưng con trỏ chỉ tham chiếu đến 1 ô nhớ còn delegate có thể tham chiếu đến nhiều ô nhớ khác
    // int chuoi = 'stack'
    // int* cursor = &chuoi <== con trỏ cursor có địa chỉ là X293.. có giá trị là ô nhớ của biến chuoi
    //Syntax : delegate Type name = method
    public delegate void DShowInfo(string msg); //  Action
    public delegate int DSum(int a , int b); // có kiểu trả về là int - Func
    class Program{
        static void info(string msg){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        static void warning(string msgw){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msgw);
            Console.ResetColor();
        }
        static int tinhTongab(int x , int y) =>  x + y;
        static int tinhHieuab(int x , int y) =>  x - y;

        static void Main(string[] args){
            DShowInfo? log = null;
            log += info;   // delegate DShowInfo cùng tham chiếu đồng thời đến 2 ô nhớ cỉa info và warning
            log("day la delegate");    // cach 2 : log.Invoke("day la delegate")

            log += warning;

            log("day la delegate");    // cach 2 : log.Invoke("day la delegate")
            //Action , Func: delegate - gereric
            Action action_dontHave; // ~ delegate void action(); dấu ~ nghĩa là tương đương
            Action<string , int> action_haveParameter; // ~delegate void action(string s, int i )
            Action<string> action_haveParameter_use_info_warning; // ~delegate void action(string s) tương đồng với DShowInfo
            action_haveParameter_use_info_warning = warning;
            action_haveParameter_use_info_warning = info;
            action_haveParameter_use_info_warning("thi hanh action");
            // Func: Func cũng giống với Action cũng là sử dụng để tạo delegate nhưng Func thì bắt buộc phải có biến trả về
          
            //Syntax Func<kieutrave> f1; // khai báo func không tham số
            //       Func<string, dounle, int> f2 // kiểu trả về là int vì nó nằm cuối( những cái đầu là tham số truyền vào)   
            Func<int , int , int> f1 = tinhTongab;
            f1 += tinhHieuab;
            int result = f1(11,5);
            Console.WriteLine(result);


        }
    }
}