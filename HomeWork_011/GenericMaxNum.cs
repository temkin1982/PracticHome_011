namespace HomeWork_011
{
    public class GenericMaxNum<T> where T : struct
    {
        public static T Max(T a, T b, T c)
        {
            T[] array = { a, b, c };
            return array.Max();
        }
    }
}
