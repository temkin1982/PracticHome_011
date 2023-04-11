namespace HomeWork_011
{
    public class GenericArrayClass<T>
    {
        private T[] array;
        private int count;

        public GenericArrayClass()
        {
            array = new T[10];
            count = 0;
        }

        public void Add(T value)
        {

            if (count < array.Length) array[count] = value; count++;

            //try
            //{
            //    if (count < array.Length) array[count] = value; count++;
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Erorro: Array is full!!!");
            //    Console.WriteLine(ex.Message);
            //}

        }

        public T[] GetElement()
        {
            T[] result = new T[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = array[i];
            }
            return result;
        }


        //public GenericArrayClass()
        //{
        //    this.array = array;
        //    array = new T[10];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //public GenericArrayClass(K valueDouble)
        //{
        //    this.valueDouble = valueDouble;
        //}



    }
}
