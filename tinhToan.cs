using System;

namespace CS09{
    public class tinhToan
    {
        public static int tinhTich(int a ,int b ){
            return a * b;
        }
        public static int tinhTong(int a ,int b ){
            return a + b;
        }
        //overloading
        public static float tinhTong(float a ,float b ){
            return a + b;
        }
        public static int binhPhuong( ref int x){
            return x = x*x;
        }
    }
}