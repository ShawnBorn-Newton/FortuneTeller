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

            int retEven = 10;
            int retOdd = 40;
            string vacationHome = "";
            

            string redCar = "a Jetta";
            string oraCar = "a jet pack";
            string yelCar = "a tour bus";
            string greCar = "a submarine";
            string bluCar = " a privet jet";
            string indCar = "a roman charriet";
            string vioCar = "a dog sled";

            int someCash = 25000;
            int moreCash = 50000;
            int bestCash = 750000;
            int failCash = 5;
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
            Console.WriteLine(" Your preferances shape you destiny as well.\n What is you favorite ROYGBIV color? If you are unfamilur with ROYGBIV type \"Help\"");
            responseColor = Console.ReadLine();
            Console.WriteLine(" Lastly, how many siblings do you have?");
            responseKin = double.Parse(Console.ReadLine());

            //color
            switch (responseColor)
            {
                case "help":
                    Console.WriteLine("ROYGBIV stands for Red, Orange, Green, Blue, Indigo, and Violet. These are your choises from the fates.");
                    break;
                default:

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

                    }
                    break;
            }
            Console.WriteLine(responseColor);


            //age
            if (responseAge % 2 == 0)
            {
                responseAge = retEven;
            }
            else
            {
                responseAge = retOdd;
            }

            if (responseKin == 0d)
            {
                vacationHome = "Japan";
            }
            else if (responseKin == 1d)
            {
                vacationHome = "New Zealand";
            }
            else if (responseKin == 2d)
            {
                vacationHome = "Hawaii";
            }
            else if (responseKin == 3d)
            {
                vacationHome = "New York";
            }
            else if (responseKin > 3d)
            {
                vacationHome = "Florida";
            }
            else
            {
                vacationHome = "a back ally";
            }
            //birth month
            if (responseMonth > 1 && responseMonth <= 4)
            {
                responseMonth = someCash;
            }
            else if (responseMonth > 5 && responseMonth <= 8)
            {
                responseMonth = moreCash;
            }
            else if (responseMonth > 9 && responseMonth <= 12)
            {
                responseMonth = bestCash;
            }
            else
            {
                responseMonth = failCash;
            }


            //print fortune

            Console.WriteLine(nameFirst + " " + nameLast + " will reire in " + responseAge + " with " 
                + responseMonth + " in the bank. a vacation home in" + responseKin + " and a \n" + responseColor);



        }
    }
}
