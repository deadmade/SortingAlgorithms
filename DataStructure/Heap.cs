namespace DataStructure
{
    public class Heap
    {
        private List<int> elements = new List<int>();

        public int Size => elements.Count;

        public bool IsEmpty => elements.Count == 0;

        public void Insert(int item)
        {
            elements.Add(item);
            HeapifyUp(Size - 1);
        }

        public int ExtractMax()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Heap is empty");

            int max = elements[0];
            elements[0] = elements[Size - 1];
            elements.RemoveAt(Size - 1);

            HeapifyDown(0);
            return max;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (elements[index] <= elements[parentIndex])
                    break;

                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        private void HeapifyDown(int index)
        {
            while (index < elements.Count / 2)
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;
                int largerChildIndex = leftChildIndex;

                if (rightChildIndex < elements.Count && elements[rightChildIndex] > elements[leftChildIndex])
                {
                    largerChildIndex = rightChildIndex;
                }

                if (elements[index] >= elements[largerChildIndex])
                    break;

                Swap(index, largerChildIndex);
                index = largerChildIndex;
            }
        }

        private void Swap(int index1, int index2)
        {
            int temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;
        }
        
        public void PrintTree()
        {
            Console.Clear();
            
            int height = (int)Math.Ceiling(Math.Log2(Size + 1));
            int maxWidth = (int)Math.Pow(2, height) - 1;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);

            for (int level = 0; level < height; level++)
            {
                int levelNodes = (int)Math.Pow(2, level);
                int spaceBetween = maxWidth / levelNodes;

                for (int i = 0; i < levelNodes; i++)
                {
                    if (queue.Count > 0)
                    {
                        int index = queue.Dequeue();
                        if (index < Size)
                        {
                            Console.Write(elements[index].ToString().PadLeft(spaceBetween));
                            queue.Enqueue(2 * index + 1);
                            queue.Enqueue(2 * index + 2);
                        }
                        else
                        {
                            Console.Write("".PadLeft(spaceBetween));
                            queue.Enqueue(-1);
                            queue.Enqueue(-1);
                        }
                    }
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}