namespace HelloEdugrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            // inmatningsHanterare
            DateTime currentDate = DateTime.Now;
            Console.WriteLine( $"Hej, {name}, på {currentDate}");
        }   
    }
}