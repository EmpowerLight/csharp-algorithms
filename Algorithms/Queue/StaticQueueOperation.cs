namespace Algorithms.Queue
{
    public class StaticQueueOperation
    {
        private int size;
        private int[] data;
        private int head;
        private int tail;

        public StaticQueueOperation(int size)
        {
            this.size = size;
            this.data = new int[size];
            this.head = 0;
            this.tail = 0;
        }

        public void printQueue()
        {
            for (int i = this.head; i < this.tail; i++)
            {
                Console.Write(this.data[i] + " ");
            }
        }

        public void enqueue(int value)
        {
            if (this.tail == this.size)
            {
                throw new Exception("Maimum size reached");
            }

            this.data[this.tail++] = value;

            
        }

        public void dequeue()
        {
            if (this.tail == 0)
            {
                throw new Exception("Empty queue");
            }
            
            for (int i = this.head; i < this.tail - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.tail--;
            
        }

    }
}
