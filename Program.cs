﻿/**
This lessons online notepad
https://www.microsoft.com/net/tutorials/csharp/getting-started

Aleksey Savin &copy; 2017
alekseysavin.com
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace csbot
{
    class Program
    {
#region lesson 12 classes
        public class Address
        {
            public string StreetAddress { get; set; } = string.Empty;
            public string City { get; set; } = string.Empty;
            public string State { get; set; } = string.Empty;
            public int PostalCode { get; set; } = 0;
            public string Country { get; set; } = string.Empty;


        }

        public class Person
        {
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            public Address ShippingAddress { get; set; }
        }

        public class Company
        {
            public string Name { get; set; }
            public Address ShippingAddress { get; set; }
        }

#endregion

        static void Main(string[] args)
        {
            #region ms lesson 12 of 20 
            Console.WriteLine("Lesson 12 start here:");
            
            //Values for Address
            string[] strts = {"Bla bla", "True stree", "Whats street?", "Tverskaya street", "Mangomery Bitch"};
            string[] citys = {"Moscow", "Sant Petersburg", "Keln", "New York", "Toronto", "Los Angeless", "Polo Alto"};
            string[] state = {"CA", "BA", "NA", "AA", "SA"};
            int[] postals = {123, 234, 345, 456, 567};
            string[] contrys = {"Russia", "Russia", "Germany", "USA", "Canada", "USA", "USA"};

            //Values for Pesons
            string[] fnames = {"Ignat", "Rahat", "Romb", "Stephan", "Narkoman"};
            string[] lnames = {"Thatov", "Rahatov", "Stomb", "Lucielly", "Buratinov"};
            
            Address adr1 = new Address();
            Address adr2 = new Address();
            Address adr3 = new Address();
            Address adr4 = new Address();
            Address adr5 = new Address();
            //Values for Company'es
            string[] names = {"xSoft", "ySoft", "zSoft", "sSoft", "rSoft" };
            Address cadr1 = new Address();
            Address cadr2 = new Address();
            Address cadr3 = new Address();
            Address cadr4 = new Address();
            Address cadr5 = new Address();
            

        adr1.City = citys[0];
        adr1.StreetAddress = strts[0];
        adr1.PostalCode = postals[0];
        adr1.State = state[0];
        adr1.Country = contrys[0];



            #endregion
            #region ms lesson 11 of 20
            Console.WriteLine("Lesson 11 start here");
            while (true)
            {
                string inputs = Console.ReadLine();
                if (inputs == "xy")
                {
                    hi();
                    bark();
                }
                if (inputs == "x")
                {
                    hi();
                }
                if (inputs == "y")
                {
                    bark();
                }
                if (inputs == "q")
                {
                    break;
                }
                if (inputs == "a")
                {
                    Console.Write(csum(1, 2));
                    Console.Write(sqrt(2));
                }
            }

            void hi()
            {
                Console.WriteLine("Hi");
            }

            void bark()
            {
                Console.WriteLine("Gav gav gav!");
            }

            int csum(int x, int y)
            {
                return x + y;
            }

            int sqrt(int x)
            {
                return x * x;
            }

            #endregion
            #region ms lesson 10 of 20
            //https://www.microsoft.com/net/tutorials/csharp/getting-started/looping-collections
            int sum = 0;
            var test = new List<int>() { 2, 4, 6 };
            for (int i = 0; i < test.Count; i++)
            {
                sum += test[i];
            }
            Console.Write(sum);
            Console.ReadLine();
            #endregion
            #region ms lesson 9 of 20 array collections
            //https://www.microsoft.com/net/tutorials/csharp/getting-started/arrays-collections
            string oper = ":";
            string read;
            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine($"Enter command (+ item, - item, or -- to clear, quit):");
                read = Console.ReadLine();
                string[] param = read.Split(' ');
                string cntnt = read.Substring(2);

                oper = param[0];

                if (oper == ":")
                {
                    Console.WriteLine("Nothing..");
                }
                if (oper == "+")
                {
                    list.Add(cntnt);
                }
                if (oper == "-")
                {
                    list.Remove(cntnt);
                }
                if (oper == "--")
                {
                    {
                        list.Clear();
                    }
                }
                list.ForEach(Console.WriteLine);
                if (oper == "quit")
                {
                    break;
                }
            }

            #endregion
            #region ms lesson 8 of 20 for loops
            //paused here https://www.microsoft.com/net/tutorials/csharp/getting-started/for-loops
            Console.WriteLine("For loop:");
            for (int x = 0; x < 4; x++)
            {
                for (int i = 0; i <= 24; i++)
                {
                    Console.Write($"{i}");
                    if (i > -1 && i < 24)
                    {
                        Console.Write($",");
                    }
                    i = i + x;
                }
                Console.WriteLine();
            }

            #endregion

            #region ms lesson 7 of 20
            Console.WriteLine("7 lesson");
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            while (number > 1) // convert this to while
            {
                int candidateFactor = 2;
                while (candidateFactor <= number) // convert this to while
                {
                    if (number % candidateFactor == 0) // found a factor
                    {
                        Console.Write(candidateFactor);
                        // divide number by the factor you found and assign this back to number
                        number = number % candidateFactor;
                        // print a comma if number is still greater than 1
                        if (number > 1)
                        {
                            Console.Write(",");
                        }
                    }
                    // don't forget to increment factor!
                    candidateFactor++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Lesson 7 end");
            #endregion

            #region lesson 6 of 20

            DateTime nowtime = DateTime.Now;
            DateTime today = DateTime.Today;

            Console.WriteLine($"nowtime: {nowtime}");
            Console.WriteLine($"today: {today}");
            // "Good Morning"
            DateTime start_mor = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +4, 0, 0);
            DateTime end_mor = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +10, 0, 0);
            if (nowtime > start_mor && nowtime < end_mor)
            {
                Console.WriteLine($"Good Morning! Now Time: {nowtime} - start&end: {start_mor} {end_mor} ");
            }
            // "Good Afternoon"
            DateTime start_day = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +10, 0, 0);
            DateTime end_day = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +16, 0, 0);
            if (nowtime > start_day && nowtime < end_day)
            {
                Console.WriteLine($"Good Afternoon! Now Time: {nowtime}");
            }
            // "Good Evening"
            DateTime start_eve = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +16, 0, 0);
            DateTime end_eve = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +22, 0, 0);
            if (nowtime > start_eve && nowtime < end_eve)
            {
                Console.WriteLine($"Good Evening! Now Time: {nowtime}");
            }
            // "Good Night"
            DateTime start_nig = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +22, 0, 0);
            DateTime end_nig = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +4, 0, 0);
            if (nowtime > start_nig)
            {
                Console.WriteLine($"Good Night! Now Time: {nowtime}");
            }

            #endregion

            #region lesson 5 of 20
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Try to guess the number, input one:");
            var input = int.Parse(Console.ReadLine());

            if (input < correctNumber)
            {
                Console.WriteLine($"Input number lower, x-number is: {correctNumber}");
            }
            else if (input == correctNumber)
            {
                Console.WriteLine($"Input number equal, x-number is {correctNumber}");
            }
            else
            {
                Console.WriteLine("$Input number grather, x-number is: {correctNumber}");
            }

            #endregion

            #region second examples
            var currentTime = DateTime.Now; // current time
            var stoday = DateTime.Today; // current date - time is midnight
            var someDate = new DateTime(2016, 7, 1); // 1 July 2016, midnight
            var someMoment = new DateTime(2016, 7, 1, 8, 0, 0); // 1 July 2016, 08:00.00
            var tomorrow = DateTime.Today.AddDays(1);
            var yesterday = DateTime.Today.AddDays(-1);
            var someDay = DateTime.Parse("7/1/2016");


            Console.WriteLine($"currentTime: {currentTime}");
            Console.WriteLine($"today: {stoday}");
            Console.WriteLine($"someDate: {someDate}");
            Console.WriteLine($"someMoment: {someMoment}");
            Console.WriteLine($"tomorrow: {tomorrow}");
            Console.WriteLine($"yesterday: {yesterday}");
            Console.WriteLine($"someDay: {someDay}");

            DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year");

            DateTime birthdate = new DateTime(1988, 3, 29);
            TimeSpan from_bday = today - birthdate;
            Console.WriteLine($"Duration from Birthday: {from_bday.TotalDays}");
            Console.WriteLine($"daysToNextAnniversary:" + (1000 - (from_bday.TotalDays % 10000)));

            #endregion

            #region first examples
            string greeting = "Hello";
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine($"{greeting}, {name}!");
            #endregion
            //You next lessons here:
            //https://www.microsoft.com/net/tutorials/csharp/getting-started/datetimes 
        }
    }
}