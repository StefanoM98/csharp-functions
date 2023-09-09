namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeriArray = {1, 2, 3, 4, 5, 6, 7};
            PrintArray(numeriArray);
            //Funzioni
            void PrintArray(int[] array)
            {
                Console.Write("[");

                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Console.Write(array[i]);
                    }
                }

                Console.WriteLine("]");

            }
        }
    }
}