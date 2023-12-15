public class Program
{
    /*
      * Van 2 autó és ki szeretném írni az adatai előszőr, 
      * után nővelni szeretném a sebességét az első autónak 
      * és szeretném csökkenteni a sebességét a második autónak 
      * és a végén újra kiszeretném írni az autók adatai újra.
    */
    static void Main(string[] args)
    {
        Console.WriteLine("**AUTO DEMO**");

        string firstAutoName = "Ford";
        string firstAutoColor = "red";
        int firstAutoYear = 2022;
        int firstAutoSpeed = 0;

        string secondAutoName = "Tesla";
        string secondAutoColor = "pink";
        int secondAutoYear = 2018;
        int secondAutoSpeed = 60;

        Console.WriteLine("\nFirst auto data:");
        Console.WriteLine($"Auto name: {firstAutoName}");
        Console.WriteLine($"Auto color: {firstAutoColor}");
        Console.WriteLine($"Auto year: {firstAutoYear}");
        Console.WriteLine($"Auto speed: {firstAutoSpeed}");

        Console.WriteLine("\nSecond auto data:");
        Console.WriteLine($"Auto name: {secondAutoName}");
        Console.WriteLine($"Auto color: {secondAutoColor}");
        Console.WriteLine($"Auto year: {secondAutoYear}");
        Console.WriteLine($"Auto speed: {secondAutoSpeed}");

        Console.WriteLine("\nSpeed up the car");
        firstAutoSpeed += 50;
        Console.WriteLine($"The auto actual speed: {firstAutoSpeed}");

        Console.WriteLine("\nSlow down the car");
        secondAutoSpeed -= 20;
        if (secondAutoSpeed < 0)
        {
            secondAutoSpeed = 0;
            Console.WriteLine($"The auto is stoped");
        }
        else
        {
            Console.WriteLine($"The auto actual speed: {secondAutoSpeed}");
        }

        Console.WriteLine("\nFirst auto data:");
        Console.WriteLine($"Auto name: {firstAutoName}");
        Console.WriteLine($"Auto color: {firstAutoColor}");
        Console.WriteLine($"Auto year: {firstAutoYear}");
        Console.WriteLine($"Auto speed: {firstAutoSpeed}");

        Console.WriteLine("\nSecond auto data:");
        Console.WriteLine($"Auto name: {secondAutoName}");
        Console.WriteLine($"Auto color: {secondAutoColor}");
        Console.WriteLine($"Auto year: {secondAutoYear}");
        Console.WriteLine($"Auto speed: {secondAutoSpeed}");
    }
}