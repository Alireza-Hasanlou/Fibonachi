namespace Fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstN = 0; 
            int secondN = 1;

            List<int> Fibonachi = new List<int>() { firstN,secondN};

            for (int i = 2; i <= number; i++)
            {
                Fibonachi.Add(Fibonachi[i - 1] + Fibonachi[i-2]);
            }

            foreach (int item in Fibonachi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
