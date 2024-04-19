namespace Algorithms.Array
{
    public class ArrayOperation
    {
        private int[] data;
        private int length;
        private int MAX_SIZE;
        public ArrayOperation(int size)
        {
            data = new int[size];
            MAX_SIZE = size;
            length = 0;
        }
        public void printArrayData()
        {
            for(int i = 0; i < length; i ++)
            {
                Console.Write(data[i] + " ");
            }
        }
        public void appendValue(int value)
        {
            if (MAX_SIZE == length)
            {
                Console.WriteLine("Array Size full cannot add the data");
                return;
            }
            data[length] = value;
            length++;
        }

        public void prependValue(int value)
        {
            if (MAX_SIZE == length)
            {
                Console.WriteLine("Array Size full cannot add the data");
                return;
            }

            for (int i = length-1; i >= 0; i--)
            {
                data[i + 1] = data[i];
            }

            data[0] = value;
            length++;
        }

        public void Insert(int index, int value) 
        {
            if (MAX_SIZE == length)
            {
                Console.WriteLine("Array Size full cannot add the data");
                return;
            }
            for (int i = length -1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = value;
            length++;
        }

        public void deleteAtTheEnd()
        {

            length--;
            if(length == -1)
            {
                length++;
                Console.WriteLine("Cannot Delete no data in the Array");
                return;
            }
            data[length] = 0;
        }

        public void deleteAtBegining()
        {
            
            if(length == 0)
            {
                Console.WriteLine("Error No Element");
                return;
            }
            for (int i = 0; i < length; i++)
            {
                data[i] = data[i + 1]; 
            }
            length--;
        }
        public void deleteAtSpecificLocation(int index)
        {
            if(index < 0 || index > length)
            {
                throw new InvalidOperationException("Invalid Index");
            }

            for(int i = index; i < length; i++)
            {
                data[i] = data[i + 1];
            }
            length--;

        }
    }
}
