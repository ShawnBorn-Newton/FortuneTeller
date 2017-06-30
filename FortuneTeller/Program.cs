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

            int retirmantYears;
            string vacationHome = "";
            string transportation = "";
            int bankMoney;
           
                //Input
            Console.WriteLine(" Welcome, let us peer through the currtens of fate!\n We shall explore your future useing special aspects of your life.");

            Console.WriteLine(" To begine we must look at your name.\n Names are powerfull forces that shape fate and are shaped in turn.\n What is your first name?");
            nameFirst = Console.ReadLine();
            Console.WriteLine(" And your last name?");
            nameLast = Console.ReadLine();
            Console.WriteLine(" How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(" We must know the turning of your star sighn.\n Give the number of your birth month.");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine(" Your preferances shape you destiny as well.\n What is you favorite ROYGBIV color? If you are unfamilur with ROYGBIV type \"Help\"");
            color = Console.ReadLine();
            Console.WriteLine(" Lastly, how many siblings do you have?");
            siblings = double.Parse(Console.ReadLine());

            //color
            switch (color)
            {
                case "help":
                    Console.WriteLine("ROYGBIV stands for Red, Orange, Green, Blue, Indigo, and Violet. These are your choises from the fates.");
                    break;
                default:

                    switch (color)
                    {

                        case "red":
                            transportation = "a nice car";
                            break;
                        case "orange":
                            transportation = "a jet pack";
                            break;
                        case "yellow":
                            transportation = "a submarine";
                            break;
                        case "Green":
                            transportation = "a rickshaw";
                            break;
                        case "blue":
                            transportation = "a work van";
                            break;
                        case "indigo":
                            transportation = "a private jet";
                            break;
                        case "violet":
                            transportation = "a roman charriet";
                            break;

                    }
                    break;
            }

            //age
            if (age % 2 == 0)
            {
                retirmantYears = 10;
            }
            else
            {
                retirmantYears = 40;
            }
            //siblings
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
            //birth month
            if (birthMonth > 1 && birthMonth <= 4)
            {
                bankMoney = 10000;
            }
            else if (birthMonth > 5 && birthMonth <= 8)
            {
                bankMoney = 10000;
            }
            else if (birthMonth > 9 && birthMonth <= 12)
            {
                bankMoney = 200000;
            }
            else
            {
                bankMoney = 5;
            }


            //print fortune

            Console.WriteLine(nameFirst + " " + nameLast + " will retire in " + retirmantYears + " with $" 
                + bankMoney + " in the bank. a vacation home in" + vacationHome + " and a \n" + transportation);



        }
    }
}
