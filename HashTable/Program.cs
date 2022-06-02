using System;

namespace HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Sentence Frequency\n 2 for Frequency in Paragraph\n 3 for Word Removal");
            Console.WriteLine("Enter a Number");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    {
                        MyMapNode<int, string> myHash = new MyMapNode<int, string>(5);
                        myHash.Add(0, "To");
                        myHash.Add(1, "Be");
                        myHash.Add(2, "Or");
                        myHash.Add(3, "Not");
                        myHash.Add(4, "To");
                        myHash.Add(5, "Be");

                        Console.WriteLine("Enter a word to find a frequency'To Be Or Not To Be'");
                        string userInput = Console.ReadLine();
                        Console.WriteLine("The frequency of " + userInput + " is: " + myHash.FrequencyOfWords(userInput));
                        break;
                    }
                case 2:
                    {
                        string givenPhrase = "Paranoids are not paranoid because they are paranoid but because " +
                                               "they keep putting themselves deliberately into paranoid avoidable situations";
                        string[] arrayOfPhrase = givenPhrase.Split(" ");
                        var distinctWords = arrayOfPhrase.Distinct();
                        int length = arrayOfPhrase.Length;
                        MyMapNode<int, string> myHash = new MyMapNode<int, string>(arrayOfPhrase.Length);
                        int i = 0;
                        foreach (string data in arrayOfPhrase)
                        {
                            myHash.Add(i, data);
                            i++;
                        }
                        foreach (string data in distinctWords)
                        {
                            Console.WriteLine(data + ": " + myHash.FrequencyOfWords(data));
                        }
                        break;
                    }
                case 3:
                    {
                        string givenPhrase = "Paranoids are not paranoid because they are paranoid but because " +
                                             "they keep putting themselves deliberately into paranoid avoidable situations";

                        string[] arrayOfPhrase = givenPhrase.Split(" ");
                        int length1 = arrayOfPhrase.Length;
                        MyMapNode<int, string> myHash = new MyMapNode<int, string>(arrayOfPhrase.Length);
                        int j = 0;
                        foreach (string data in arrayOfPhrase)
                        {
                            myHash.Add(j, data);
                            j++;
                        }

                        foreach (string data in arrayOfPhrase)
                        {
                            if (data == "avoidable")
                            {
                                myHash.Remove(0);
                                continue;
                            }
                            Console.Write(String.Join("",data," "));
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a Valid Number");
                        break;
                    }
            } 
        }
    }
}
