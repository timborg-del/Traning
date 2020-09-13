
using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace FirstAssagnment
{
    class Program
    {

        static void Main(string[] args)
        {
            double firstnum;
            double secoundnum;
            double answer;
            string ops;




            Console.WriteLine("Terminal miniräknare \n");
            while (true)
            {

                Console.WriteLine("Välj en operator: (+, -, *, /, %,\n");
                ops = Console.ReadLine();


                Console.WriteLine("Sätt första talet \n");
                firstnum = Double.Parse(Console.ReadLine());

                Console.WriteLine("Sätt in andra talet\n");
                secoundnum = Double.Parse(Console.ReadLine());

                if (ops == "+")
                {
                    Console.WriteLine(Add(firstnum, secoundnum));
                }

                else if (ops == "-")
                {
                    Console.WriteLine(Subb(firstnum, secoundnum));
                }

                else if (ops == "*")
                {
                    Console.WriteLine(multi(firstnum, secoundnum));
                }

                else if (ops == "/") // När jag tryckt på / så går jag in i funktion under om  inte är 0 så går jag till else   
                {
                    if (secoundnum != 0 && firstnum != 0)
                    // om andra numret inte är = 0 gå till else
                    {
                        Console.WriteLine(Divi(firstnum, secoundnum));
                    }
                    else
                    {
                        Console.WriteLine("dela med 0 detta nummer går ej");
                    }
                }

                else if (ops == "%")
                {
                    Console.WriteLine(Modular(firstnum, secoundnum));

                }
                Console.WriteLine("Vill du fortsätta programmet "); // While Lägg till variabel string för att ge ett alternativ om att försätta lopen.
                string more = Console.ReadLine();
                if (more == "nej")
                {
                    break;
                }




            }//end While



        }//end of main

        static double Add(double talEtt, double talTvo)
        {

            return talEtt + talTvo;
        }

        static double Divi(double one, double two)

        {
            if (one != 0 && two != 0)
            {
                return one / two;

            }
            else
            {
                Console.WriteLine("this is wrong number");
                return 0;
            }

        }

        static double Subb(double one1, double two2)
        {
            return one1 - two2;
        }
        static double multi(double tal1, double tal2)
        {
            return tal1 * tal2;
        }
        
        static double Modular(double tal3, double tal4)
        {
            return tal3 % tal4;
        }
            




    }
}
