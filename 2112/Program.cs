namespace _2112
{
    internal class Program
     {
        static void Main()
        {
            int a;
            Console.WriteLine("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            if((a % 3 == 0)&&(a % 5 == 0))
            {
                Console.WriteLine("fezzbuzz");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else if(a % 3 == 0) {
                Console.WriteLine("fizz");
            }
        }
    }
}