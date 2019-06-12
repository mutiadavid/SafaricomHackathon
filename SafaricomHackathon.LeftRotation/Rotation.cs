using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafaricomHackathon.LeftRotation
{
    public class Rotation
    {
        /// <summary>
        /// Rotates an array to the left n times
        /// </summary>
        /// <param name="array">The array we want to rotate</param>
        /// <param name="n">Number of rotations</param>
        /// <returns></returns>
        public int[] RotateToLeft(int[] array, int n)
        {
            try
            {
                if (array == null || array.Length <= 1 || n == 0) return array;

                //avoiding fixed array size error
                var arrayToRotate = array.ToList();
                for (int i = 0; i < n; i++)
                {
                    //for each loop we want to move first element to the back of our array
                    //get first element within the array
                    var firstElement = arrayToRotate[0];

                    //we remove the first element
                    arrayToRotate.RemoveAt(0);

                    //add the first element back 
                    arrayToRotate.Add(firstElement);
                }
                return arrayToRotate.ToArray();
            }
            catch (Exception ex)
            {
                //log error
                Console.WriteLine($"Error occured: {ex.Message}");
                return null;
            }
        }
    }
}
