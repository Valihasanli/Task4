namespace task4._3
{
    internal class Program
    {// Array-in içerisinde verilmiş A herfi ile başlayan elementleri ekrana yazdıran method(example : {"Anar" , "Eli" , "Yusif" , "Arif" } ==> Anar , Arif)
        public static void A(string[] s) {
            for (int i = 0;i<s.Length;i++)
            {
                for (int j = 0; j < s[i].Length; j++)
                {
                    string b = s[i];
                    if (b[0] == 'A') { Console.WriteLine(b); }
                    break;
                }
            }
             }
        static void Main(string[] args)
        {
            string[] a = { "Alim", "Axund", "Hesen","abdulla","Azer" };
            A(a);
        }
    }
}
