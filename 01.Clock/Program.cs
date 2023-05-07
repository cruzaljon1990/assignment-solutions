namespace _01.Clock;
class Program
{
    static void Main(string[] args)
    {
        int hour, minute;
        Console.WriteLine("=== Clock Hands Distance Calculator ===");
        Console.WriteLine("Enter hour: ");
        while (!Int32.TryParse(Console.ReadLine(), out hour))
        {
            Console.WriteLine("Invalid input, try again! Enter hour: ");
        }
        Console.WriteLine("Enter minute: ");
        while (!Int32.TryParse(Console.ReadLine(), out minute))
        {
            Console.WriteLine("Invalid input, try again! Enter minute: ");
        }
        Clock clock = new Clock(hour,minute);
        Console.WriteLine($"Output: {clock.Calculate.ToString()}");
    }
}

