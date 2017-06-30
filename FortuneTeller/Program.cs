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
            //Input
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
           
            //color
            switch (responseColor)
            {
                case "red":
                    responseColor = redCar;
                    break;
                case "orange":
                    responseColor = oraCar;
                    break;
                case "yellow":
                    responseColor = yelCar;
                    break;
                case "Green":
                    responseColor = greCar;
                    break;
                case "blue":
                    responseColor = bluCar;
                    break;
                case "indigo":
                    responseColor = indCar;
                    break;
                case "violet":
                    responseColor = vioCar;
                    break;
                case "help":
                    Console.WriteLine("ROYGBIV stands for Red, Orange, Green, Blue, Indigo, and Violet. These are your choises from the fates.");
                    break;
            }
            //age
            if (responseAge % 2 == 0)
            {
                responseAge = retEven;
            }
            else
            {
                responseAge = retOdd;
            }

            if(responseKin == 0)
            {
                responseKin = localZero;
            }
            else if(responseKin == 1)
            {
                responseKin = localOne;
            }
            else if(responseKin == 2)
            {
                responseKin = localTwo;
            }
            else if(responseKin ==3)
            {
                responseKin = localThree;
            }
            else if(responseKin > 3)
            {
                responseKin = localMost;
            }
            else
            {
                responseKin = localFail;
            }
            //birth month
            if (responseMonth > 1 && responseMonth < 4)
            {
                responseMonth = someCash;
            }
            else if (responseMonth > 5 && responseMonth < 8)
            {
                responseMonth = moreCash;
            }
            else if (responseMonth > 9 && responseMonth < 12)
            {
                responseMonth = bestCash;
            }
            else
            {
                responseMonth = failCash;
            }

            //print fortune

            Console.WriteLine(nameFirst + nameLast + responseAge + responseMonth + responseKin + responseColor);



        }
    }
}
