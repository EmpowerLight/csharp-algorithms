namespace Algorithms.Stack
{
    public class DynamicStaticOperation
    {
        public StackNode top;
        public StackNode head;
        public DynamicStaticOperation()
        {
            this.top = null;
            this.head = null;
        }

        public void printList()
        {
            StackNode currentNode = this.head;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }
        }

        public void push(int value)
        {
            StackNode newNode = new StackNode(value);
            if (this.top == null)
            {
                this.top = newNode;
                this.head = this.top;
                return;
            }

            StackNode currentNode = this.head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
            this.top = newNode;
        }


        public void pop()
        {
            if (this.top == null)
            {
                throw new Exception("Stack is empty");
            }
            if (this.head == this.top)
            {
                this.head = null;
                this.top = null;
                return;
            }

            
            StackNode currentNode = this.head;
            while (currentNode.Next != this.top)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = null;
            this.top = currentNode;
        }


    }
}
