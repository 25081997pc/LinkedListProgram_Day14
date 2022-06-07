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

            //list.RemoveFirstNode();
            //Console.WriteLine("------");
            //list.Display();

            //list.RemoveLastNode();
            //Console.WriteLine("------");
            //list.Display();

            //list.Search(30);
            //Console.WriteLine("------");
            //list.Display();
            //List<Node> nodes = new List<Node>();

            list.insertAtPosition(40, 3);
            Console.WriteLine("List");
            list.Display();

            list.pop_at(3);
            Console.WriteLine("List");
            list.Display();

        }
    }
}