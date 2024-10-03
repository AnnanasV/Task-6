namespace BuyerQueue
{
    public class Buyers
    {
        private Queue<string> buyers;

        public Buyers()
        {
            buyers = new Queue<string>();
        }

        public void Add(string name)
        {
            buyers.Enqueue(name);
            Console.WriteLine($"Buyer {name} was added");
        }

        public void Serve()
        {
            Console.WriteLine($"Serving {buyers.Peek}...");
            buyers.Dequeue();
            Console.WriteLine("Next buyer!");
        }

        public void Count()
        {
            Console.WriteLine($"{buyers.Count()} people in queue");
        }
    }
}