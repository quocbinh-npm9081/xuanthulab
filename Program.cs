namespace XuanThuLab
{
    //extenstion menthods
    //operator
    static class Abc {
        public static void Print(this string s, ConsoleColor color){
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }

    class Vector{
        public int x;
        public int y;
        public Vector(int _x, int _y){
            this.x = _x;
            this.y = _y;
        }
        public static Vector operator+(Vector v1, Vector v2){
            return new Vector(v1.x+v2.x, v1.y+v2.y);
        }
        public int this[int i]{// indexer (truy xuất tài nguyền thông qua chỉ mục)
            set{
                switch(i){
                    case 0 :
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    default :
                        throw new Exception("Chi so sai");
                }
            }
            get{
                    switch(i){
                    case 0 :
                        return x;
                    case 1:
                        return y;
                    default :
                        throw new Exception("Chi so sai");
                }
            }
        }
    }
    class Program{
        static void Main(string[] args){
            string s = "Xin Chao Cac Ban";
            s.Print(ConsoleColor.DarkBlue);

            //operator cộng 2 vector
            // vector1 + vector2 = (x1+x2, y1+y2)
            Vector vector1 = new Vector(1,5);
            Vector vector2 = new Vector(21,2);
            // vector 1 + vector 2
            Vector vector3 = vector1 + vector2;
            Console.WriteLine($"Vector1 (x={vector1.x},y={vector1.y}) + Vector2 (x={vector2.x}, y={vector2.y}) = Vector3({vector3.x},{vector3.y})");

            Console.WriteLine(vector1[1]);
            Console.WriteLine(vector1[3]); // vector1[3] không có trong chỉ mục
        }
    }
}