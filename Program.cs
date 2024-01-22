namespace RemoveIndex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Here: ");
            string userString = Console.ReadLine();
            Console.WriteLine("Enter Index: ");
            int Index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userString.Remove(Index, 1));
        }
    }
}
