using System;

namespace SortArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteArrayValues(SortArrayValues(ReadArrayValues()));
        }

        static int[] ReadArrayValues()
        {
            Console.Write("Please enter array size:");
            var size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Please enter array value:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }
        
        static void WriteArrayValues(int[] array)
        {
            Console.WriteLine("SortedArray:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }

        static int[] SortArrayValues(int[] array)
        {
            int temp = 0;

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }

            return array;
        }
    }
}
