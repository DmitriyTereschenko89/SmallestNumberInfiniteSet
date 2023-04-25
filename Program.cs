namespace SmallestNumberInfiniteSet
{
    internal class Program
    {
        public class SmallestInfiniteSet
        {
            private readonly PriorityQueue<int, int> priorityQueue;
            private readonly HashSet<int> unique;

            public SmallestInfiniteSet()
            {
                priorityQueue = new PriorityQueue<int, int>();
                unique = new HashSet<int>();
                for(int num = 1; num <= 1000; ++num)
                {
                    unique.Add(num);
                    priorityQueue.Enqueue(num, num);
                }
            }

            public int PopSmallest()
            {
                int minimumElement = priorityQueue.Dequeue();
                unique.Remove(minimumElement);
                return minimumElement;
            }

            public void AddBack(int num)
            {
                if (unique.Add(num))
                {
                    priorityQueue.Enqueue(num, num);
                }
            }
        }

        static void Main(string[] args)
        {
            SmallestInfiniteSet smallestInfiniteSet = new();
            smallestInfiniteSet.AddBack(2);    // 2 is already in the set, so no change is made.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 1, since 1 is the smallest number, and remove it from the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 2, and remove it from the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 3, and remove it from the set.
            smallestInfiniteSet.AddBack(1);    // 1 is added back to the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 1, since 1 was added back to the set and
                                               // is the smallest number, and remove it from the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 4, and remove it from the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 5, and remove it from the set.
        }
    }
}