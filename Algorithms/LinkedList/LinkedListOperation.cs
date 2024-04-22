namespace Algorithms.LinkedList
{
    public class LinkedListOperation
    {
        // head pointer
        public Node head { get; set; }

        public LinkedListOperation()
        {
            this.head = null;
        }

        // pint all the value 
        public void printList()
        {
            Node currentNode = this.head; 

            while(currentNode != null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }
        }


        // Add Node at the end of the list
        public void append(int value)
        {
            Node newNode = new Node(value);
            
            if (this.head == null)
            {
                this.head = newNode;
                return;
            }

            Node currentNode = this.head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = newNode;

        }

        // Add Node at the begining of the list
        public void prepend(int Value)
        {
            Node newNode = new Node(Value);

            if (this.head == null)
            {
                this.head = newNode;
                return;
            }

            newNode.Next = this.head;
            this.head = newNode;

        }

        // return the previous node from the given index
        private Node _traverseNode(int index)
        {

            int count = index-1;

            Node currentNode = this.head;
            while(count > 0)
            {
                currentNode = currentNode.Next;
                count--;
            }

            return currentNode; 

        }

        // Add node at particular index

        public void insert(int Value, int index)
        {
            Node newNode = new Node(Value);

            if(index == 0 && this.head != null)
            {
                this.prepend(Value);
                return;
            }

            if (this.head == null && index > 0)
            {
                throw new Exception("list is empty and invalid index");
            } 

            Node leaderNode = this._traverseNode(index);
            Node holdingNode = leaderNode.Next;
            leaderNode.Next = newNode;
            newNode.Next = holdingNode;

        }
        // Delete Node from Begining
        public void deleteAtBeg()
        {
            if(this.head == null)
            {
                throw new Exception("List is empty!");
            }

            this.head = this.head.Next;
        }

        // Delete Node from the end of the list
        public void deleteAtEnd()
        {
            if(this.head == null)
            {
                throw new Exception("List is empty!");
            }

            Node curretNode = this.head;

            while(curretNode.Next.Next != null)
            {
                curretNode = curretNode.Next;
            }
            curretNode.Next = null;
        }

        // Delete Node from specific index
        public void remove(int index)
        {
            if (this.head == null && index > 0)
            {
                throw new Exception("list is empty and invalid index");
            }

            if (index == 0 && this.head != null)
            {
                this.deleteAtBeg();
                return;
            }

            Node leaderNode = this._traverseNode(index);
            Node holdingNode = leaderNode.Next;
            leaderNode.Next = holdingNode.Next;
        }

    }
}
