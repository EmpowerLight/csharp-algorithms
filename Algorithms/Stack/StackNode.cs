namespace Algorithms.Stack
{
    public class StackNode
    {
        public int Value { get; set; }
        public StackNode Next { get; set; }

        public StackNode(int Value) 
        { 
            this.Value = Value;
            Next = null;
        }

    }
}
