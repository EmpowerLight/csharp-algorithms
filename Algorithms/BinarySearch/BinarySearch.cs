using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinarySearch
{
    public class BinarySearch
    {
        public int binarySearch(int l, int k, int[] data, int key)
        {
            if (l <= k) // Base case: check if boundaries are valid
            {
                int mid = (l + k) / 2; // Calculate mid using correct formula
                if (data[mid] == key)
                {
                    return mid;
                }
                else if (data[mid] > key)
                {
                    return binarySearch(l, mid - 1, data, key); // Search left half
                }
                else
                {
                    return binarySearch(mid + 1, k, data, key); // Search right half
                }
            }
            return -1; // Key not found
        }

    }
}
