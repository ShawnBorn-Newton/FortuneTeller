using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string nameFirst;
            string nameLast;
            string color;
            int age;
            int birthMonth;
            double siblings;

            //age
            int retiremantYears;
            //siblings
            string vacationHome = "";
            //color
            string transportation = "";
            //birthMonth 
            int bankMoney; 
           
                //Greating
            Console.WriteLine(" Welcome, let us peer through the curtains of fate!\n We shall explore your future using special aspects of your life.");
                //Input
            Console.WriteLine(" To begin we must look at your name.\n Names are powerful forces that shape fate and are shaped in turn.\n What is your first name?");
                nameFirst = Console.ReadLine();
            Console.WriteLine(" And your last name?");
                nameLast = Console.ReadLine();
            Console.WriteLine(" How old are you?");
                age = int.Parse(Console.ReadLine());
            Console.WriteLine(" We must know the turning of your star sign.\n Give the number of your birth month.");
                birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine(" Your preferences shape your destiny as well.\n What is you favorite ROYGBIV color? If you are unfamilur with ROYGBIV type\n \"Help\"");
                color = Console.ReadLine().ToLower();
           

            //color nested switch
            switch (color)
            {
                case "help":
                    Console.WriteLine("ROYGBIV stands for Red, Orange, Green, Blue, Indigo, and Violet. These are your choices from the fates.\n"
                        + "Please enter one now.");
                    color = Console.ReadLine().ToLower();
                    break;
                default:
                    //
                    switch (color)
                    {
                        case "red":
                            transportation = "a nice car.";
                            break;
                        case "orange":
                            transportation = "a jet pack.";
                            break;
                        case "yellow":
                            transportation = "a submarine";
                            break;
                        case "Green":
                            transportation = "a rickshaw.";
                            break;
                        case "blue":
                            transportation = "a work van.";
                            break;
                        case "indigo":
                            transportation = "a private jet.";
                            break;
                        case "violet":
                            transportation = "a roman chariot.";
                            break;
                        default:                            
                            transportation = "a hover board.";
                            break;                           
                     }
                      break;
                }

                //age if
            if (age % 2 == 0)
                {
                    retiremantYears = 10;
                }
            else
                {
                    retiremantYears = 40;
                }
            //siblings if else
            Console.WriteLine(" Lastly, how many siblings do you have?");
            siblings = double.Parse(Console.ReadLine());

            if (siblings == 0d)
                {
                    vacationHome = "Japan";
                }
            else if (siblings == 1d)
                {
                    vacationHome = "New Zealand";
                }
            else if (siblings == 2d)
                {
                    vacationHome = "Hawaii";
                }
            else if (siblings == 3d)
                {
                    vacationHome = "New York";
                }
            else if (siblings > 3d)
                {
                    vacationHome = "Florida";
                }
            else
                {
                    vacationHome = "a back ally";
                }
            //birth month if else
            if (birthMonth >= 1 && birthMonth <= 4)
                {
                    bankMoney = 10000;
                }
            else if (birthMonth >= 5 && birthMonth <= 8)
                {
                    bankMoney = 10000;
                }
            else if (birthMonth >= 9 && birthMonth <= 12)
                {
                    bankMoney = 200000;
                }
            else
                {
                    bankMoney = 5;
                }
            

            //print fortune (ding)

            Console.WriteLine(nameFirst + " " + nameLast + " will retire in " + retiremantYears + " years with $" 
                + bankMoney.ToString("N0") + " in the bank,\n a vacation home in " + vacationHome + " and\a " + transportation);



        }
    }
}
