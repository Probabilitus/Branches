namespace Fruits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruitsLegumes = new List<string>()
            {
                "pommes",
                "baanane",
                "fraises",
                "pomme de terre"

            };
            foreach (string fruit in fruitsLegumes)
            {
                Console.WriteLine(fruit);
            }

            
            
        }
    }
}
