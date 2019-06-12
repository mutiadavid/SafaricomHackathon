using System;
using System.Collections.Generic;

namespace SafaricomHackathon.LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var rotation = new Rotation();

            var array = new int[] { 1, 2, 3, 7, 9 };

            var rotatedArray = rotation.RotateToLeft(array,1000000);

            Console.WriteLine("Before Rotation: ");
            PrintArray(array);

            Console.WriteLine("After Rotation: ");
            PrintArray(rotatedArray);
        }

        static void PrintArray(IList<int> array)
        {
            Console.Write("[");
            if (array != null)
            {
                string arrayString = "";
                foreach (var item in array)
                {
                   arrayString += $"{item.ToString()},";
                }

                arrayString = arrayString.TrimEnd(',');
                Console.Write(arrayString);
            }
            
            Console.WriteLine("]");
        }
    }
}
