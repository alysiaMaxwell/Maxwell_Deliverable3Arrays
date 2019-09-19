using System;

namespace Maxwell_Deliverable3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Declare array to auto populate

                int[] numbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25};
                          
                // Iterate through array elements 

                foreach (int i in numbers)
                {
                    
                    Console.WriteLine("Element Value = " + i + ""); 
                }
            }
            catch
            {
                Console.WriteLine("Please exit the program and try again!"); 
            }
        }
    }
}
