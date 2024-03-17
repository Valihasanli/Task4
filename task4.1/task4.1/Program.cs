namespace task4._1
{
    internal class Program
    {// 2 string array-i içerisindeki ortaq elementleri tapib ekrana yazdiran metod;
        public static string[] Equality(string[] a, string[] b)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j=0;j< b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        Console.WriteLine(b[j]);
                        break;
                    }
                }
            }
            return [];
        }
         static void Main(string[] args)
        {
            string[] arr1 = {   "sahda l","bwq","12"};
            string[] arr2 = { "bwq","12" };
            Equality(arr1,arr2) ;
        }
    }
}
