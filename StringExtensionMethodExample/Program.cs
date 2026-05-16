namespace StringExtensionMethodExample
{
    public static class StringExtension
    {

        public static string  spaceToUnderscore( this string st)
        {
            string newString = "";
            foreach (var s in st) {

                if (s == ' ')
                {

                    newString += "_";
                }
                else
                    newString += s;

              
            }

            return newString;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Samuel Yacoub Ishak Ghataas".spaceToUnderscore());
        }
    }
}
