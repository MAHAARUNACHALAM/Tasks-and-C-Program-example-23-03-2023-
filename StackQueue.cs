//Try Catch

namespace console1
{
    class StackQueue
    {
        static void Main(String[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Hello");
            stack.Push("World");
            stack.Push("!");
            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Pop: {0}", stack.Pop());
            Console.WriteLine("Peek: {0}", stack.Peek());
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("World");
            queue.Enqueue("!");
            foreach (string s in queue)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Dequeue: {0}", queue.Dequeue());
            Console.WriteLine("Peek: {0}", queue.Peek());
            Console.WriteLine(queue.TryPeek);

        }

    }
}