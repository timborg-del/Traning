using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

namespace HängaGubbe
{

    class Meny
    {
        static void Main()
        {
            //List<string> secretWord = new List<string> { "sverige", "finland", "danmark", "norge" };

            //// string[] strAdDetailsID = new string[4];
            //// Random random = new Random();
            //for (int i = 0; i < 4; i++)
            //{

            //    int index = random.Next(0, secretWord.Count);
            //    string value = secretWord[index].ToString();
            //    secretWord.RemoveAt(index);
            //    strAdDetailsID[i] = value;
            //}

            //strAdDetailsID.Dump();



            //new Random();
            //var secretWord = new List<string> { "sverige", "finland", "danmark", "norge" };
            //int index = Random.Next(secretWord.Count); RandomNumberGenerator


            // lägg till ord och gör dom random 
            //string[] secretWord = { "sverige", "finland", "danmark", "norge" };
            //string[] secretWord = // Nu kör den hela arrayen samtidigt
            //generera random länder.
            //Console.WriteLine(secretWord); //lista ut array
            //int Go = rnd.random(secretWord.Length);

            //string random = (secretWord[new Random().next])
            //Random rand = new Random();
            //int index = rand.Next(secretWord.Length);
            //string[] words = new string[4];   //
            //words[0] = "Sverige";
            //words[1] = "Norge";
            //words[2] = "Finland";
            //words[3] = "Finland";

            var random = new Random();
            var words = new List<string> { "sverige", "finland", "danmark", "norge" };
            int index = random.Next(words.Count);
            // Kolla upp hur jag ska flytta en sträng från random från en string array.
            
            


            List<string> letterGuessed = new List<string>(); // Alternativ "static void ExKeyChar ()" char aSymbole1 = Console.Readkey().KeyChar aSymbole2 = Console.Readkey(true).KeyChar
            int live = 10;
            Console.WriteLine("Welcome To Hangman Game");
            Console.WriteLine("Guess for what country in scandinavia im thinking of its {0} countrys to geuss on", .Length);
            Console.WriteLine("you have {0} in health", live); // Liv index
            Isletter(secret, letterGuessed); // kallar på Metoden 
            while (live > 0)
            {
                string input = Console.ReadLine();
                if (letterGuessed.Contains(input))
                {
                    Console.WriteLine("You enter letter [{0}] already", input);
                    Console.WriteLine("Try a Drifferent Word");
                    GetAlphabet(input); // här måste vi kalla på kod för att kolla alfabete 
                    continue;
                }//skriver ut gissad bokstav
                letterGuessed.Add(input);
                if (IsWord(secret, letterGuessed))
                {
                    Console.WriteLine(secretWord);
                    Console.WriteLine("Congratzzz!!");
                    break;
                }
                else if (secretWord[4].Contains(input))  //Contains char or text  for place it in right order Use secretWordindexOF  Stringbuilder.Tostring().contains Do not work with special char.
                {
                    Console.WriteLine("Nice entry");
                    string letters = Isletter(secretWord, letterGuessed);
                    Console.WriteLine(letters);
                }
                else
                {
                    Console.WriteLine("Letter not in my word");   //If im guessing wrong im -=1 in health and array points at health
                    live -= 1; // ??
                    Console.WriteLine("you have in health {0}", live);
                }
                Console.WriteLine();
                if (live == 0)
                {
                    Console.WriteLine("Game Over \nMy Secret Word is [ {0} {1} {2} {3} ]", secretWord);
                    break;
                }
            }
            Console.ReadKey();
        }
        static bool IsWord(string[] secretWord, List<string> lettersGuessed) // Lägg till 
        {
            bool word = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                string c = Convert.ToString(secretWord[i]);
                if (lettersGuessed.Contains(c))
                {
                    word = true;
                }
                else
                {
                    return word = false;
                }
            }
            return word;
        }
        static string Isletter(string[] secretWord, List<string> lettersGuessed) // Kör for loop kollar så att att om bokstaven finns i index alltså ordet och ger antingen ut bokstaven eller text handling hon the right side
        {
            string correctletters = "";
            for (int i = 0; i < secretWord.Length; i++)
            {
                string c = Convert.ToString(secretWord[i]);
                if (lettersGuessed.Contains(c))
                {
                    correctletters += c;
                }
                else
                {
                    correctletters += "_ ";
                }
            }
            return correctletters;
        }
        static void GetAlphabet(string letters)
        {
            List<string> alphabet = new List<string>();
            for (int i = 1; i < 100; i++) // engelskt alfabet.  // 26 alternativ bokstäver ta bort en 
            {
                char alpha = Convert.ToChar(i + 96); //?? Acii
                alphabet.Add(Convert.ToString(alpha));
            }
            int num = 49; //ascci
            Console.WriteLine("letters left are :");  // berättar hur många bokstäver det finns kvar.
            for (int i = 0; i < num; i++)
            {
                if (letters.Contains(letters))
                {
                    alphabet.Remove(letters);
                    num -= 1;
                }
                Console.Write("[" + alphabet[i] + "] ");    // Kolla tangentbordet alfabetet
            }
            Console.WriteLine();
        }
    }
}







