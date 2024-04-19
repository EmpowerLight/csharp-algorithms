using Algorithms.BinarySearch;

BinarySearch bs = new BinarySearch();

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };


Console.WriteLine(bs.binarySearch(0, arr.Length-1, arr, 1));