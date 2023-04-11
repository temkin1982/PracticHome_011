namespace HomeWork_011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание 11.1 //

            GenericArrayClass<int> genericArray = new GenericArrayClass<int>();
            int[] array = new int[10];
            try
            {
                Console.WriteLine("Enter 10 number: ");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                    genericArray.Add(array[i]);
                }
                
            }
            catch (IndexOutOfRangeException err)
            {
               Console.WriteLine("Erorr: Array is full!!!");
                Console.WriteLine(err.Message);
            }


            Console.WriteLine("Elements in the array is 10: ");
            foreach (var item in genericArray.GetElement())
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"|\t{item}\t|\n");
            }

            Console.ReadLine();



            // Домашнее задание 11.2 //

            Console.WriteLine(GenericMaxNum<int>.Max(3, 8, 1));

            
            
        }

    }
}
