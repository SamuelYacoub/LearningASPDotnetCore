namespace aspnet_pro022_DictionaryReview
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dictionary<int, string> users = new();


            users.Add(3,"garges");
            users.Add(4, "mina");


            Dictionary<int, string> products = new() {
                { 1, "phone"},
                { 399,"laptop"},
                { 33,"washing machine"}



            };

            Dictionary<int, string> employees = new() {

                [100025]="markous pola",
                [10002555]="chritiano folobatiire",
                [1000266] = "samy lami",




            };
            
            foreach(var item in users) {
                Console.WriteLine(item.Key +" "+item.Value);
            
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            foreach (var item in products)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            foreach (var item in employees)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }


        }
    }
}
