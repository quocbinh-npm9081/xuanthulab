namespace SanPham
{
    public partial class Product{
        public string name {set; get;}
        public decimal price {set; get;}
        public Product(string name,string decription = ""){
            this.name= name;
            this.decription = decription;
        }
        public string getInfo(){
            return $"{name} - {price} - {decription}";
        }
    }
}