namespace Algorithms.LinearSearch
{
    public class LinearSearch
    {
        public int linearSearch(int[] data, int key)
        {
            if(data == null)
            {
                throw new InvalidOperationException("Array sould not be null");
            }

            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
