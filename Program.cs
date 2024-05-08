namespace Fruits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>()
            {
                "pommes",
                "baanane",
                "fraises",

            };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            
            
        }
    }
}
