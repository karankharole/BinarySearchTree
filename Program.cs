namespace BinarySearchTreeNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Binary<int> binary = new Binary<int>(56);
            binary.Add(30);
            binary.Add(70);
            binary.Display();
            Console.ReadKey();
        }
    }
}