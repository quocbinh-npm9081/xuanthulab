namespace XuanThuLab
{
    //null và nullable
    //null là không tham chiếu đến vùng nhớ nào cả 
    class Program{

        static  void Main(string[] args){
            int? a;// trong C# kiểu dữ liệu nguyên thủy( là kiểu dữ liệu tham trị được lưu trên Stack không được phép null, nếu muốn null thì phải có toán tử int? )
            a = null;
            a = 10;
            if(a.HasValue){//proprety HasValue để kiểm tra xem biến a có tham chiếu đến ô nhớ nào hay không( HasValue tương tự a != null)
                Console.WriteLine($"bien a: {a.Value}");
            }

        }
    }
}