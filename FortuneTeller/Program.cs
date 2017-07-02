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
            //siblings, needed to convert double siblings into string. should this be here or with statment? 
            string vacationHome = "";
            //color, needed to make nested switch work
            string transporation = "";
                
            //Greating
            Console.WriteLine(" Welcome, let us peer through the curtains of fate!\n We shall explore your future using special aspects of your life.");
                
            //Input
            Console.WriteLine(" To begin we must look at your name.\n Names are powerful forces that shape fate and are shaped in turn.\n What is your first name?");
                string nameFirst = Console.ReadLine();

            Console.WriteLine(" And your last name?");
                string nameLast = Console.ReadLine();

            Console.WriteLine(" How old are you?");
                int age = int.Parse(Console.ReadLine());

            Console.WriteLine(" We must know the turning of your star sign.\n Give the number of your birth month.");
                int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine(" Your preferences shape your destiny as well.\n What is you favorite ROYGBIV color? If you are unfamilur with ROYGBIV type\n \"Help\"");
                string color = Console.ReadLine().ToLower();


            //color nested switch
            if (color == "help")
            {
                Console.WriteLine("ROYGBIV stands for Red, Orange, Green, Blue, Indigo, and Violet. These are your choices from the fates.\n"
                    + "Please enter one now.");
                color = Console.ReadLine().ToLower();
                switch (color)
                {
                    case "red":
                        transporation = "a nice car.";
                        break;

                    case "orange":
                        transporation = "a jet pack.";
                        break;

                    case "yellow":
                        transporation = "a submarine";
                        break;

                    case "green":
                        transporation = "a rickshaw.";
                        break;

                    case "blue":
                        transporation = "a work van.";
                        break;

                    case "indigo":
                        transporation = "a private jet.";
                        break;

                    case "violet":
                        transporation = "a roman chariot.";
                        break;

                    default:
                        transporation = "a hover board.";
                        break;
                 }//end switch
             }// end if

                else
            { 
                    switch (color)
                {
                        case "red":
                            transporation = "a nice car.";
                            break;

                        case "orange":
                            transporation = "a jet pack.";
                            break;

                        case "yellow":
                            transporation = "a submarine";
                            break;

                        case "green":
                            transporation = "a rickshaw.";
                            break;

                        case "blue":
                            transporation = "a work van.";
                            break;

                        case "indigo":
                            transporation = "a private jet.";
                            break;

                        case "violet":
                            transporation = "a roman chariot.";
                            break;

                        default:                            
                            transporation = "a hover board.";
                            break;                           
                 }//end switch2

             }//end else

                //age if
            if (age % 2 == 0)
                {
                    age = 10;
                }

            else
                {
                    age = 40;
                }
           
            //siblings if else (I had to put the write and read lines here to make this happen in the correct order.) 
            Console.WriteLine(" Lastly, how many siblings do you have?");
            double siblings = double.Parse(Console.ReadLine());

            if (siblings == 0)
                {
                    vacationHome = "Japan";
                }

            else if (siblings == 1)
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
                    birthMonth = 10000;
                }

            else if (birthMonth >= 5 && birthMonth <= 8)
                {
                    birthMonth = 15000;
                }

            else if (birthMonth >= 9 && birthMonth <= 12)
                {
                    birthMonth = 200000;
                }

            else
                {
                    birthMonth = 5;
                }
            
            //print fortune (ding)
            Console.WriteLine(nameFirst + " " + nameLast + " will retire in " + age + " years with $" 
                + birthMonth.ToString("N0") + " in the bank,\n a vacation home in " + vacationHome + " and\a " + transporation);



        }//end static void Main
    }//end class Program
}//end namespace FortuneTeller
