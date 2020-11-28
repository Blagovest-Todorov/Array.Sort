using System;

namespace _15.ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3 , 100, 450, 21, 1};
            Array.Sort(numbers); //sort the Arrray in ascending way from smallest to largest number
            //Array.Sort(numbers);
            Array.Reverse(numbers); //after the array is sortedf , if we use Array.Reverse() :
            //the it prints it descendingly
            //valid  and works  only for one dimensional arrays

            foreach (var item in numbers ) 
            {
                Console.WriteLine(item);
            }


        }
    }
}
