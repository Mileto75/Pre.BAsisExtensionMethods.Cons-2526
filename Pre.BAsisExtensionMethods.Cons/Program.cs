using System.Threading.Channels;

namespace Pre.BAsisExtensionMethods.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension methods basics");
            string words = "One Two Three Four Five Six Seven Eight Nine Ten";
            IEnumerable<int> numbers = [1, 2, -3, 4, 5, 6, 7, 8, 9, 10];
            //string word counter
            var wordsArray = words.Split(" ");
            var numberOfWords = wordsArray.Count();
            Console.WriteLine($"Number of words = {numberOfWords}");
            //string character counter
            
            //int isEven checker
            
            //Ienumerable int kleinste getal
            
            //ienumerable string random waarde uit lijst retourneren
            
            //return all even numbers
            
            //mapping
            
            //Extra:generic ienumerable random waarde retourneren uit lijst
        }
    }
}