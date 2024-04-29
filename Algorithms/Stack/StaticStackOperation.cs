namespace Algorithms.Stack
{
    
    public class StaticStackOperation
    {
        private int size;
        private int[] data;
        private int top;
        public StaticStackOperation(int size) 
        {
            this.size = size;
            data = new int[this.size];
            top = -1;
        }

        public void printList()
        {
            for(int i = 0; i <= top; i++)
            {
                Console.Write(data[i] + " ");
            }
        }

        public void push(int value)
        {
            if (value == null)
            {
                throw new Exception("Value cannot be null");
            }
            if (top + 1 == size)
            {
                throw new Exception("not enough space");
            }
            data[++top] = value;

        }

        public void pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack is empty");
            }
            data[top--] = 0;
            
        }

    }
}
