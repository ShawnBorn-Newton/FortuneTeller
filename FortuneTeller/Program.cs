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
            //User Input and creat vars
            string nameFirst;
            string nameLast;
            string responseColor;
            int responseAge;
            int responseMonth;
            double responseKin;

            int    retEven;
            int    retOdd;
            string localZero;
            string localOne;
            string localTwo;
            string localThree;
            string localMost;
            string localFail;

            string redCar;
            string oraCar;
            string yelCar;
            string greCar;
            string bluCar;
            string indCar;
            string vioCar;

            int someCash;
            int moreCash;
            int bestCash;
            string failCash;

            Console.WriteLine(" Welcome, let us peer through the currtens of fate!\n We shall explore your future useing special aspects of your life.");

            Console.WriteLine(" To begine we must look at your name.\n Names are powerfull forces that shape fate and are shaped in turn.\n What is your first name?");
            nameFirst = Console.ReadLine();
            Console.WriteLine(" And your last name?");
            nameLast = Console.ReadLine();
            Console.WriteLine(" How old are you?");
            responseAge = int.Parse(Console.ReadLine());
            Console.WriteLine(" We must know the turning of your star sighn.\n Give the number of your birth month.");
            responseMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Color \"Help\"");
            responseColor = Console.ReadLine();
            Console.WriteLine("Siblings");
            responseKin = double.Parse(Console.ReadLine());

            switch (responseColor)
            {
                case "red":

                    break;
                case "orange":

                    break;
                case "yellow":

                    break;
                case "Green":

                    break;
                case "blue":

                    break;
                case "indigo":

                    break;
                case "violet":

                    break;
            }
            if (responseAge % 2 == 0)
            {
                responseAge = retEven;
            }
            else
            {
                responseAge = retOdd;
            }
            //use vars to put together fortune


            //print fortune
        }
    }
}
