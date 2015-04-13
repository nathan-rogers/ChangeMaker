using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
            ChangeAmount(4.19m);
            Console.WriteLine();
            ChangeAmount(3.18m);
            Console.WriteLine();
            ChangeAmount(.99m);
            Console.WriteLine();
            ChangeAmount(12.93m);
            Console.ReadKey();
        }

        /// <summary>
        /// Counts sever different change rates of currency until proper change has been counted.
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>The correct amount of change per exhange rate</returns>
        public static Change ChangeAmount(decimal amount)
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();


            //while there is money left to count
            while (amount > 0.00m)
            {
                //if subtracting a quarter leaves money to count
                if (amount - .25m > 0.00m)
                {
                    //add 1 to quarters
                    amountAsChange.Quarters++;
                    //subtract 25 cents
                    amount = amount - .25m;
                }
                //if subtracting 10 cents leaves money to count
                else if (amount - .10m > 0.00m)
                {
                    //add a counter to dimes
                    amountAsChange.Dimes++;
                    //subtract 10 cents
                    amount -= .10m;
                }
                //if subtracting 10 cents leaves money to count
                else if (amount - .05m > 0.00m)
                {
                    //add 1 to nickels
                    amountAsChange.Nickles++;
                    //subtract 5 cents
                    amount -= .05m;
                }
                //if there are pennies left
                else if (amount - .01m >= 0.00m)
                {
                    //add 1 to pennies
                    amountAsChange.Pennies++;
                    //subtract a penny
                    amount -= .01m;
                }

                ////if there are 4 quarters 
                //if (amountAsChange.Quarters >= 4)
                //{
                //    //add 1 to dollars
                //    amountAsChange.Ones++;
                //    //subtract 4 quarters
                //    amountAsChange.Quarters -= 4;
                //}
                ////if there are 5 ones
                //else if (amountAsChange.Ones >= 5)
                //{
                //    //add 1 to 5's
                //    amountAsChange.Fives++;
                //    //subtract 5 ones
                //    amountAsChange.Ones -= 5;
                //}
                ////if there are 2 5's
                //else if (amountAsChange.Fives >= 2)
                //{
                //    //add 1 to 10's
                //    amountAsChange.Tens++;
                //    //subtract 2 5's
                //    amountAsChange.Fives -= 2;
                //}
                ////if there are 2 10's
                //else if (amountAsChange.Tens >= 2)
                //{
                //    //add 1 to 20's
                //    amountAsChange.Twenties++;
                //    //subtract 2 10's
                //    amountAsChange.Tens -= 2;
                //}
                ////if there are 2 20's AND 1 10
                //else if (amountAsChange.Twenties >= 2 && amountAsChange.Tens > 0)
                //{
                //    //add 1 to 50's
                //    amountAsChange.Fifties++;
                //    //subtract 2 20's
                //    amountAsChange.Twenties -= 2;
                //    //subtract 1 10
                //    amountAsChange.Tens -= 1;

                //}
                ////if there are 2 50's
                //else if (amountAsChange.Fifties >= 2)
                //{
                //    //add 1 to 100's
                //    amountAsChange.Hundreds++;
                //    //subtract 2 50's
                //    amountAsChange.Fifties -= 2;
                //}

            }
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);
            Console.WriteLine("Dimes: " + amountAsChange.Dimes);
            Console.WriteLine("Nickels: " + amountAsChange.Nickles);
            Console.WriteLine("Pennies: " + amountAsChange.Pennies);
            Console.WriteLine("Ones:  " + amountAsChange.Ones);
            Console.WriteLine("Fives: " + amountAsChange.Fives);
            Console.WriteLine("Tens: " + amountAsChange.Tens);
            Console.WriteLine("Twenties: " + amountAsChange.Twenties);
            Console.WriteLine("Fifties: " + amountAsChange.Fifties);
            Console.WriteLine("Hundreds: " + amountAsChange.Hundreds);


            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is property to hold the number of ones to be returned as change
        /// </summary>
        public int Ones { get; set; }

        /// <summary>
        /// This is property to hold the number of fives to be returned as change
        /// </summary>
        public int Fives { get; set; }

        /// <summary>
        /// This is property to hold the number of tens to be returned as change
        /// </summary>
        public int Tens { get; set; }

        /// <summary>
        /// This is property to hold the number of twenties to be returned as change
        /// </summary>
        public int Twenties { get; set; }

        /// <summary>
        /// This is property to hold the number of fifties to be returned as change
        /// </summary>
        public int Fifties { get; set; }

        /// <summary>
        /// This is property to hold the number of hundredsto be returned as change
        /// </summary>
        public int Hundreds { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
            this.Ones = 0;
            this.Fives = 0;
            this.Tens = 0;
            this.Twenties = 0;
            this.Fifties = 0;
            this.Hundreds = 0;
        }
    }
}
