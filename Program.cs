using System;

namespace CaesarCipher
{
    class Program
    {
        //this method shifts the original character to a specific character based on 
        //the key given by the user.
        public static char charToEncrypt(char c, int key)
        {
            //check if the character is a number
            //if it is a number, we return it, if not, we shift the char based on key specified.
            if (char.IsNumber(c))
            {
                return c;
            }


            return (char)(c+key);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to encrypt: ");
            string stringToEncrypt = Console.ReadLine();

            string output = string.Empty;

            foreach(char c in stringToEncrypt)
            {
                output += charToEncrypt(c, 1);
            }

            Console.WriteLine($"{output}");

        }
    }
}
