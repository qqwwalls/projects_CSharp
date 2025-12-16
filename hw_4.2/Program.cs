namespace hw_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Information about your shop: ");
            Shop shop = new Shop("Florens","Odesa st. Tiraspolska","flowers and coffee","+380 8746 736","flow@gmail.com");
            shop.show();
        }
    }
}
