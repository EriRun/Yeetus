using yeetus;

internal class Program
{
    private static void Main(string[] args)
    {
        var perosn = new Person { Age = 69 };
        var bday = Logic.CalculateBron(perosn.Age);
        Console.WriteLine(bday);
    }
}