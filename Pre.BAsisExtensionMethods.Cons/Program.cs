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
            //string letter counter
            int numberOfLetters = 0;
            foreach(var character in words)
            {
                if(character != ' ')
                    numberOfLetters++;
            }
            Console.WriteLine($"Number of letters = {numberOfLetters}");

            //int isEven checker
            //number on position x
            if (numbers.ToArray()[1] %2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("OnEven");

            //Ienumerable int kleinste getal
            var minimum = numbers.ToArray()[0];
            foreach(var number in numbers)
            {
                if (minimum > number)
                    minimum = number;
            }
            Console.WriteLine($"Smallest number = {minimum}");
            //ienumerable string random waarde uit lijst retourneren

            //return all even numbers

            //mapping

            //Extra:generic ienumerable random waarde retourneren uit lijst
        }
    }
}