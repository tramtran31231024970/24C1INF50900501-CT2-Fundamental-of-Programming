// See https://aka.ms/new-console-template for more information
using System;
namespace StringExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            //bai01();//1. Print a String
            //bai02();//2. Find String Length
            //bai03();//3. Separate Individual Characters
            //bai04();//4. Print Characters in Reverse Order
            //bai05();//5. Count Words
            //bai06();//6. Compare two strings without using a string library functions
            //bai07();//7. Count the number of alphabets, digits and special characters in a string
            //bai08();//8. Copy one string to another string
            //bai09();//9. Count the number of vowels or consonants
            //bai10();//10. Find the maximum number of characters 
        }
        static void bai01()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();
            Console.WriteLine("The string you entered is: " + str);
        }
        static void bai02()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();
            int length = 0;
            foreach (char c in str)
            {
                length++;
            }
            Console.WriteLine("Length of the string is: " + length);
        }
        static void bai03()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("The characters of the string are: ");
            foreach (char c in str)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        static void bai04()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("The characters of the string in reverse are: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
        }
        static void bai05()
        {
           Console.Write("Input the string: ");
            string str = Console.ReadLine();
            int wordCount = 1; // Start with 1 for the first word
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    wordCount++;
                }
            }
            Console.WriteLine("Total number of words in the string is: " + wordCount); 
        }
        static void bai06()
        {
            Console.Write("Input the 1st string: ");
            string str1 = Console.ReadLine();
            Console.Write("Input the 2nd string: ");
            string str2 = Console.ReadLine();
            if (str1.Length == str2.Length)
            {
                bool isEqual = true;
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        isEqual = false;
                    }
                }
            }
        }
        static void bai07()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();
            int alphabets = 0, digits = 0, specialChars = 0;
            foreach (char c in str)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    alphabets++;
                }
                else if (c >= '0' && c <= '9')
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }
            Console.WriteLine("Number of Alphabets in the string is: " + alphabets);
            Console.WriteLine("Number of Digits in the string is: " + digits);
            Console.WriteLine("Number of Special characters in the string is: " + specialChars);
        }
        static void bai08()
        {
            Console.Write("Input the string: ");
            string str1 = Console.ReadLine();
            string str2 = str1;
            Console.WriteLine("The First string is: " + str1);
            Console.WriteLine("The Second string is: " + str2);
            Console.WriteLine("Number of characters copied: " + str1.Length);
        }
        static void bai09()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();
            int vowels = 0, consonants = 0;
            foreach (char c in str)
            {
                if ("aeiouAEIOU".IndexOf(c) != -1)
                {
                    vowels++;
                }
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    consonants++;
                }
            }
            Console.WriteLine("The total number of vowel in the string is: " + vowels);
            Console.WriteLine("The total number of consonant in the string is: " + consonants);
        }
        static void bai10()
        {
          Console.Write("Input the string: ");
            string str = Console.ReadLine();
            var charCounts = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }
            var maxChar = charCounts.OrderByDescending(x => x.Value).First();
            Console.WriteLine("The Highest frequency of character '{0}' appears number of times: {1}", maxChar.Key, maxChar.Value);  
        }
    }
}
        
        
