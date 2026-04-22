using Pre.BasisExtensionMethods.Cons;
using Pre.BasisExtensionMethods.Cons.Extensions;
using Pre.BasisExtensionMethods.Core.Entities;
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
            Console.WriteLine($"Number of words = {words.CountWords()}");
            //string letter counter
            //int numberOfLetters = 0;
            //foreach(var character in words)
            //{
            //    if(character != ' ')
            //        numberOfLetters++;
            //}
            Console.WriteLine($"Number of letters = {words.CountLetters()}");

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
            var random = new Random();
            var randomIndex = random.Next(0, wordsArray.Count() - 1);
            var randomWord = wordsArray.ToArray()[randomIndex];
            Console.WriteLine($"Random word = {randomWord}");
            //return all even numbers
            List<int> evenNumbers = new();
            foreach(var number in numbers)
            {
                if (number % 2 == 0)
                    evenNumbers.Add(number);
            }
            Console.WriteLine($"Even numbers = {string.Join(" ",evenNumbers)}");
            //mapping from entity to movie
            var movie = new Movie
            {
                Title = "Deadpool vs Wolverine",
                GenreId = 1,
                Genre = "Action Marvel",
                Actors = new List<string> { "Ryan Renolds","Hugh Jackman" },
                YearPublished = new DateTime(2022,12,25),
                Id = 1
            };
            var moviesIndexViewModel = new MoviesIndexViewModel
            {
                Title = movie.Title,
                Genre = movie.Genre,
                Actors = movie.Actors
            };
            Console.WriteLine($"MoviesIndexVieModel:{moviesIndexViewModel.Title}, " +
                $"{moviesIndexViewModel.Genre}, {moviesIndexViewModel.Actors}");
            
            //Extra:generic ienumerable random waarde retourneren uit lijst
        }
    }
}