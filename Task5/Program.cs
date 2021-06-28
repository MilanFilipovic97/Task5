using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 20, 40, 70, 50, 10 };
            int counter = 0;
            //int k = -10;
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = i; j < numArray.Length; j++)
                {
                    if ((numArray[i] + numArray[j]) % 60 == 0)
                    {
                        int[] newArray = new int[] { numArray[i], numArray[j] };
                        Console.WriteLine("[" + newArray[0] + "," + newArray[1] + "] ");
                        counter++;
                    }
                }

            }
            Console.WriteLine("Output " + counter);


            //second example

            int[] numArray2 = new int[] { 30, 30, 30 };
            int counter2 = 0;
            //int k = -10;
            Console.WriteLine(numArray2.Length);
            for (int i = 0; i < numArray2.Length; i++)
            {
                for (int j = i + 1; j < numArray2.Length; j++)
                {
                    if ((numArray2[i] + numArray2[j]) % 60 == 0)
                    {
                        int[] newArray = new int[] { numArray2[i], numArray2[j] };
                        Console.WriteLine("[" + newArray[0] + "," + newArray[1] + "] ");
                        counter2++;
                    }
                }

            }
            Console.WriteLine("Output " + counter2);

        }
    }
}
