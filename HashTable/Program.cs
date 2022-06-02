using System;

namespace HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyMapNode<int, string> myHash = new MyMapNode<int, string>(5);
            myHash.Add(0, "To");
            myHash.Add(1, "Be");
            myHash.Add(2, "Or");
            myHash.Add(3, "Not");
            myHash.Add(4, "To");
            myHash.Add(5, "Be");

            Console.WriteLine("Enter a word to find a frequency'To Be Or Not To Be'");
            string userInput=Console.ReadLine();
            Console.WriteLine("The frequency of "+userInput+" is: "+myHash.FrequencyOfWords(userInput));
        }
    }
}
