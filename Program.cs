namespace Assignment_3._1._4
{
    //Contains a function that takes an int array and finds the first
    //two consecutive 1s and changes them to 0s
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 2, 1, 1, 9, 1 };
            PrintArray(myArray);
            
            FindAndChangeConsecutiveValues(myArray);

            PrintArray(myArray);
            
        }


        static void FindAndChangeConsecutiveValues(int[] array)
        {
            int previousValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if ((previousValue == 1) && (array[i] == 1))
                {
                    array[i - 1] = 0;
                    array[i] = 0;
                    break;
                }
                else
                {
                    previousValue = array[i];
                }
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
