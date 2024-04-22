namespace Algorithms.LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int Value)
        {
            this.Value = Value;
            this.Next = null;
        }
    }
}
