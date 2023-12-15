using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args)
    {
        var result = BenchmarkRunner.Run<OOP.RunDemoOOP>();
    }
}

public class OOP
{
    public class Auto
    {
        string autoName { get; set; }
        string autoColor { get; set; }
        int autoYear { get; set; }
        int autoSpeed { get; set; }

        public Auto(string autoName, string autoColor, int autoYear, int autoSpeed)
        {
            this.autoName = autoName;
            this.autoColor = autoColor;
            this.autoYear = autoYear;
            this.autoSpeed = autoSpeed;
        }

        public void WriteOutAutoData()
        {
            Console.WriteLine("\nAuto data:");
            Console.WriteLine($"Auto name: {autoName}");
            Console.WriteLine($"Auto color: {autoColor}");
            Console.WriteLine($"Auto year: {autoYear}");
            Console.WriteLine($"Auto speed: {autoSpeed}");
        }

        public void Accelerate(int speedValue)
        {
            Console.WriteLine("\nSpeed up the car");
            autoSpeed += speedValue;
            Console.WriteLine($"The auto actual speed: {autoSpeed}");
        }

        public void Brake(int brakeValue)
        {
            Console.WriteLine("\nSlow down the car");
            autoSpeed -= brakeValue;
            if (autoSpeed < 0)
            {
                autoSpeed = 0;
                Console.WriteLine($"The auto is stoped");
            }
            else
            {
                Console.WriteLine($"The auto actual speed: {autoSpeed}");
            }
        }
    }

    public class RunDemoOOP
    {
        [Benchmark]
        public void Run()
        {
            Auto auto = new Auto("Ferrari", "blue", 2023, 100);

            auto.WriteOutAutoData();
            auto.Accelerate(50);
            auto.Brake(100);
            auto.WriteOutAutoData();

        }
    }
}

public class NOOP
{

}
