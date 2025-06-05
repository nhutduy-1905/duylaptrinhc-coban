namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "abcde";
            string newCh = "";
            string ch = "";
            foreach(char c in str)
            {
                ch = char.ToUpper(c).ToString();
                newCh += ch;

            }
            Console.WriteLine(newCh);
        }
    }
}
