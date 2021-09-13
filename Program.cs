using System;

namespace CaesarCipher
{
    class Program
    {
        //this method shifts the original character to a specific character based on 
        //the key given by the user.
        public static char CharToEncrypt(char c, int key)
        {
            //check if the character is a number
            //if it is a number, we return it, if not, we shift the char based on key specified.
            //We can use this if statement. However, it will return special characters for white spaces etc.
            //if (!char.IsNumber(c))
            //{
            //    return c;
            //}


            //check if the character is not a letter
            //if it's not a letter, we return it, if it is, we return & shift the char based on key specified.
            if (!char.IsLetter(c))
            {
                return c;
            }


            //we use the modulus operator to get the remainder of the key
            //caesar cipher is from 0-25, so if the user enters 26 as the key, the designated output resets respectively.
            return (char)(c + (key % 26));
        }


        //this method allows us to decrypt the encrypted message/input
        //basically the vice versa of the above method (CharToEncrypt)
        public static char CharToDecrypt(char c, int key)
        {
            if (char.IsLetter(c))
            {
                return (char)(c - (key % 26));
            }

            return c;

        }



        //this method encrypts the input and combines every single character in one whole string.
        public static string Encrypt(string stringToEncrypt, int key)
        {
            string output = string.Empty;

            //loop through the entire string to get each character
            //and use the CharToEncrypt method to encrypt the letters based on the key given by the user.
            foreach (char c in stringToEncrypt)
            {
                output += CharToEncrypt(c, key);
            }

            return output;
        }

        //this method decrypts the encrypted message
        public static string Decrypt(string stringToDecrypt, int key)
        {
            string output = string.Empty;

            foreach(char c in stringToDecrypt)
            {
                output += CharToDecrypt(c, key);
            }

            return output;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter a string to encrypt: ");
            string input = Console.ReadLine();

            Console.Write("Enter key: ");
            int key = int.Parse(Console.ReadLine());

            string encryptedMessage = Encrypt(input, key);
            Console.WriteLine($"Encrypted Message: {encryptedMessage}");

            string decryptedMessage = Decrypt(encryptedMessage, key);
            Console.WriteLine($"Decrypted Message: {decryptedMessage}");



        }
    }
}
