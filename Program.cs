using System;

namespace _15.ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 }; //declaring and initializing the array
            //sort the arra from last to first comparing each element
            Array.Sort<int>(arr, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            foreach (int item in arr) //printing the elements from the reversed array
            {
                Console.Write(item + " ");
            }



        }
    }
}
