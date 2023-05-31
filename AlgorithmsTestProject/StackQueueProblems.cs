namespace AlgorithmsTestProject
{
    public class Stack<T> : IStack<T>
    {
        private int top = 0;
        private int size;

        private T[] stack;

        public Stack(int size = 10)
        {
            this.size = size;
            stack = new T[size];
        }


        public void Push(T x)
        {
            if (top > size)
            {
                throw new Exception("Stack overflow");
            }
            else
            {
                stack[top] = x;
            }
            top++;
        }

        public T Pop()
        {
            var element = stack[top-1];
            top--;
            return element;
        }

        public T Peek()
        {
            var tmp = this.Pop();
            this.Push(tmp);
            return tmp;
        }

        public bool IsEmpty { get; }
    }

    public class Queue<T> : IQueue<T>
    {
        private int top = -1;
        private int size;

        private List<T> queue;

        public Queue()
        {
            queue = new List<T> { };
        }

        public void Enqueue(T x)
        {
            queue.Insert(0, x);
        }

        public T Dequeue()
        {
            var tmp = queue.Last();
            queue.Remove(queue.Last());
            return tmp;
        }

        public T Peek()
        {
            
            return queue.Last();
        }

        public bool IsEmpty { get; }
    }

    public class PriorityQueue<T> : IPriorityQueue<T>
    {

        private int top = -1;
        private int size;

        private List<(T,int)> priorityQueue;

        public PriorityQueue()
        {
            priorityQueue = new List<(T,int)> { };
        }

        public bool IsEmpty { get; }

        public void Enqueue(int priority, T element)
        {
            priorityQueue.Insert(0,(element, priority));
        }

        public T PeekHighestPriority()
        {
            if (priorityQueue.Count == 0)
            {
                throw new Exception("empty queue");

            }
            else
            {
                var result=priorityQueue.Max(t=>t.Item1);
                return result;
            }
        }

        public T DequeueHighestPriority()
        {
            var result = priorityQueue.Max(t => t.Item1);
            var remove = priorityQueue.Max();
            priorityQueue.Remove(remove);
            return result;
        }
    }

    public class QueueFromStack<T> : IQueue<T>
    {
        public readonly Stack<T> S1 = new();
        public readonly Stack<T> S2 = new();

        public void Enqueue(T x)
        {
            throw new NotImplementedException();
        }

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty { get; }
    }

    public class StackFromQueue<T> : IStack<T>
    {
        public readonly Queue<T> Q1 = new();
        public readonly Queue<T> Q2 = new();
        public void Push(T x)
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty { get; }
    }
}
