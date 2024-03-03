using System;
using System.Collections.Generic;

namespace COMP003A.Assignment7
{
    /*
    * Author: Saul Barajas
    * Course: COMP003A-L01
    * Purpose: Assignment 7
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Array - CharacterCounter Section
            Console.WriteLine("Array - CharacterCounter Section");
            Console.Write("Enter a single letter: ");
            char letterInput = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Enter a word: ");
            string wordInput = Console.ReadLine();
            Console.WriteLine($"The character '{letterInput}' appears in '{wordInput}' {CharacterCounter(letterInput, wordInput)} times.");
            SectionSeparator();

            // Array - IsPalindrome Section
            Console.WriteLine("Array - IsPalindrome Section");
            Console.Write("Enter a word: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Is '{userInput}' a palindrome? {IsPalindrome(userInput)}");
            SectionSeparator();

            // List - Add Section
            Console.WriteLine("List - Add Section");
            List<string> names = new List<string>();
            char userInputAdd = default;
            do
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                names.Add(name);
                Console.Write("Press any key to add more or (e) to exit: ");
                userInputAdd = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userInputAdd != 'e');

            // List - Traversal Section
            Console.WriteLine("List - Traversal Section");
            TraverseList(names);
            SectionSeparator();

            // List - Reverse Traversal Section
            Console.WriteLine("List - Reverse Traversal Section");
            TraverseListReverse(names);
        }

        static void SectionSeparator(string sectionName = "")
        {
            Console.WriteLine("-------------------------" + (string.IsNullOrEmpty(sectionName) ? "" : $" {sectionName}") + "-------------------------");
        }

        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();
            foreach (char c in word)
            {
                if (c == characterInput)
                    count++;
            }
            return count;
        }

        static bool IsPalindrome(string word)
        {
            string reversedWord = "";
            word = word.ToLower();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return word == reversedWord;
        }

        static void TraverseList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
