using OOP;

class Program
{
    /*
     * Van 2 autó és ki szeretném írni az adatai előszőr, 
     * után nővelni szeretném a sebességét az első autónak 
     * és szeretném csökkenteni a sebességét a második autónak 
     * és a végén újra kiszeretném írni az autók adatai újra.
     */
    static void Main(string[] args)
    {
        Auto ford = new Auto("Ford", "red", 2022, 0);
        Auto tesla = new Auto("Tesla", "pink", 2018, 60);

        Console.WriteLine("**AUTO DEMO**");

        ford.WriteOutAutoData();
        tesla.WriteOutAutoData();
        ford.Accelerate(50);
        tesla.Brake(20);
        ford.WriteOutAutoData();
        tesla.WriteOutAutoData();
    }
}