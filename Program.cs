using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

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
            string[] words = new string[4];
            words[0] = "sverige";
            words[1] = "norge";
            words[2] = "finland";        //length för array pekar direkt på storleken medans en count räknar elementen. count mer till lista..
            words[3] = "danmark";

            var random = new Random();
            int index = random.Next(words.Length);

            //hämtar ut hemligheten ur arrayen med index som vi fick från random
            string secret = words[index];

            // Kolla upp hur jag ska flytta en sträng från random från en string array.


            int health = 10;
            Console.WriteLine("Welcome To Hangman Game");
            Console.WriteLine("Guess for what country in scandinavia im thinking of its {0} countrys to geuss on", words.Length);
            Console.WriteLine("you have {0} in health", health); // Liv index

            StringBuilder lettersGuessed = new StringBuilder();
            string progress = CheckProgress(secret, lettersGuessed.ToString());

            Console.WriteLine(progress);  //Skriver ut fel och rätt.

            while (health > 0)
            {
                string input = Console.ReadLine();
                if (lettersGuessed.ToString().Contains(input))
                {
                    Console.WriteLine("You enter letter [{0}] already", input);
                    Console.WriteLine("Try a Drifferent Letter");
                    continue;
                }

                lettersGuessed.Append(input);
                if (CheckCorrectWord(secret, lettersGuessed.ToString())) /// lista utav av bokstäver som conventeras till sträng...
                {
                    Console.WriteLine(secret); // är rätt ord 
                    Console.WriteLine("Congratzzz!!");
                    break;
                }

                // Gissningen var rätt på bokstav
                if (secret.Contains(input))  //Contains char or text  for place it in right order Use secretWordindexOF  Stringbuilder.Tostring().contains Do not work with special char.
                {
                    Console.WriteLine("Nice entry");
                    progress = CheckProgress(secret, lettersGuessed.ToString());
                    Console.WriteLine(progress);
                    continue;
                }
               
                Console.WriteLine("Letter not in my word");   //If im guessing wrong im -=1 in health and array points at health
                health--; // ??
                Console.WriteLine("you have in health {0}", health);
                
                Console.WriteLine();
                if (health == 0)
                {
                    Console.WriteLine("Game Over \nMy Secret Word is [ {0} {1} {2} {3} ]", secret);
                    break;
                }
            }
            Console.ReadKey();
        }
        static bool CheckCorrectWord(string secret, string lettersGuessed) // Lägg till 
        {

            foreach (char secretLetter in secret)
            {
                //Gissningarna innehåller inte bokstaven vi är på, kan ej vara rätt ord
                if (!lettersGuessed.Contains(secretLetter.ToString()))
                {
                    return false;
                }
            }
            //Check letter. 

            //for (int i = 0; i < secret.Length; i++)
            //{
            //    if (!lettersGuessed.Contains(secret[i].ToString())) // inte [i] för att kunna plocka ut en bokstav ur ordet.
            //    {
            //        return false;
            //    }
            //}

            // Alla bokstäver i hemliga ordet finns i gissningarna, rätt ord!
            return true;
        }

        static string CheckProgress(string secret, string lettersGuessed) // Kör for loop kollar så att att om bokstaven finns i index alltså ordet och ger antingen ut bokstaven eller text handling hon the right side
        {
            StringBuilder progress = new StringBuilder();

            foreach(char secretLetter in secret)
            {
                if(lettersGuessed.Contains(secretLetter.ToString())) {
                    progress.Append(secretLetter);
                    continue;
                }
                progress.Append("_ ");
            }

            return progress.ToString();
        }
    }
}







