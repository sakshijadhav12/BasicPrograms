using System;

namespace BasicPrograms
{
    internal class VowelOrCosonant
    {
        public void CheckVowelOrConsonant()
        {
            Console.WriteLine("Enter an alphabet:");
            char alphabet = char.ToLower(Console.ReadKey().KeyChar);

            if (IsVowel(alphabet))
            {
                Console.WriteLine("\nThe entered alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("\nThe entered alphabet is a consonant.");
            }
        }

        public bool IsVowel(char ch)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char vowel in vowels)
            {
                if (vowel == ch)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
