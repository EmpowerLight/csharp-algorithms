namespace Algorithms.Queue
{
    public class DynamicQueueOperation
    {
        private QueueNode head;
        private QueueNode tail;

        public DynamicQueueOperation()
        {
            this.head = null;
            this.tail = null;
        }

        public void printQueue()
        {
            QueueNode currentNode = this.head;

            while (currentNode != null)
            {
                Console.Write(currentNode.value + " ");
                currentNode = currentNode.next;
            }
        }
        public void enqueue(int value)
        {
            QueueNode newNode = new QueueNode(value); 

            if (this.head == null)
            {
                this.head = newNode;
                this.tail = this.head;
                return;
            }

            this.tail.next = newNode;
            this.tail = newNode;

        }

        public void dequeue()
        {
            if (this.head == null)
            {
                throw new Exception("Queue is empty");
            }

            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
                return;
            }

            this.head = this.head.next;
        }
    }
}
