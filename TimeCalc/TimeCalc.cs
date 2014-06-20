using System;

public class TimeCalc
    {
        public static void Main(string[] args)
        {
            //Welcome
            Console.WriteLine("Welcome to Zack's Timecard Calculator");
            Console.WriteLine();

            //Ask user for hour
            Console.WriteLine("Enter clock in hour: ");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Ask user for minute
            Console.WriteLine("Enter clock in minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Ask user for future time
            Console.WriteLine("Would you like to enter the time you'll work in 'decimal' form or 'standard' form?: ");
            string response = Console.ReadLine();

            //Create instance
            TimeCalc calc = new TimeCalc();

            if (response == "standard")
            {
                //Ask user for hour
                Console.WriteLine("Enter hours you will work today: ");
                int hourFuture = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Ask user for minute
                Console.WriteLine("And how many minutes?: ");
                int minutesFuture = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Print future time
                calc.getStandard(hour, minutes, hourFuture, minutesFuture);

            }
            else
            {
                //Ask user for hour
                Console.WriteLine("Enter hours you will work today: ");
                int hourFuture = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Decimal form
                Console.WriteLine("And how many minutes in decimal form: ");
                double dec = double.Parse(Console.ReadLine());

                //Print future time
                calc.getDec(hour, minutes, hourFuture, dec);
                
            }



            Console.ReadLine();
        }

    void getStandard(int hour, int minutes, int hourFuture, int minutesFuture)
    {
        int a = hour + hourFuture;
        if (a > 12)
        {
            a = a - 12;
        }
        int b = minutes + minutesFuture;
        if (b > 60)
        {
            a = a + 1;
            b = b - 60;
        }

        Console.WriteLine("When you clock out, it will be " + a + ":" + b);

    }

    void getDec(int hour, int minutes, int hourFuture, double dec)
    {
        int a = hour + hourFuture;
        if (a > 12)
        {
            a = a - 12;
        }
        double b = minutes + (dec*60);
        if (b > 60)
        {
            a = a + 1;
            b = b - 60;
        }

        Console.WriteLine("When you clock out, it will be " + a + ":" + b);
    }

    }

