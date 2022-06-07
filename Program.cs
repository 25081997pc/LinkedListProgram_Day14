namespace LinkedListDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the linked list");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            list.Display();

            List<Node> nodes = new List<Node>();
          
        }
    }
}