namespace task4._2
{
    internal class Program
    {public static int A(int[] ints) {
            int h = 1;
            for(int i = 0; i < ints.Length;i++)
            {
                h *= ints[i];
            }
            return h;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 ,5};
            Console.WriteLine(A(arr));
        }
    }
}
