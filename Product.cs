namespace CS16
{
    class Product<A>{
        A ID {set; get;}
        public Product(A _id){
            this.ID = _id;
        }
        public void PrintInfo(){
            Console.WriteLine(this.ID);
        }

    }
}