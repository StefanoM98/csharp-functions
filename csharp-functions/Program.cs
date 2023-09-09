namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeriArray = {2, 6, 7, 5, 3, 9};
            //Stampo l'array dei numeri
            StampoArray(numeriArray);

            //Stampo un numero chiesto ma al quadrato
            StampoArray(ArrayAlQuadrato(numeriArray));

            //Stampo ora di nuovo l'array per verificare che sia intatto
            StampoArray(numeriArray);

            // Stampo la somma di tutti i numeri dell'array
            Console.WriteLine($"La somma degli elementi dell'array è: {SommaElementiArray(numeriArray)}");

            // Stampo ora la somma di tutti i numeri dell'array elevati al quadrato
            Console.WriteLine($"La somma degli elementi dell'array elevati al quadrato è: {SommaElementiArray(ArrayAlQuadrato(numeriArray))}");

            //Funzioni
            void StampoArray(int[] array)
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

            int Quadrato(int numero)
            {
                return numero * numero;
            }

            
            int[] ArrayAlQuadrato(int[] array)
            {
                int[] copiaArray = (int[])array.Clone();

                for(int i = 0; i < copiaArray.Length; i++)
                {
                    copiaArray[i] = Quadrato(copiaArray[i]);
                }
                return copiaArray;
            }

            int SommaElementiArray(int[] array)
            {
                int somma = 0;

                for (int i = 0; i< array.Length; i++)
                {
                    somma += array[i];
                }
                return somma;
            }
        }
    }
}