using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(12);
            array[7] = 4;
            Console.WriteLine(array[7]); 

        }
        class MyArray
        {
            int[] arr;

            public MyArray(int size) => arr = new int[size];

            public int this[int index]
            {
                get => arr [index];
                set => arr[index] = value * value;
            }
        }
    }
}
