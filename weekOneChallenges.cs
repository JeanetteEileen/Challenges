using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_weekOneChallenges
{
    [TestClass]
    public class WeekOneChallenges
    {
        [TestMethod]
        public void SetfirstNameLastNameAge()
        {
            // declare and initialize first name last name and age
            string firstName = "Jeanette";
            string lastName = "Schriner";
            int age = 59;
            int sum = age + 7;
            Console.WriteLine(sum);
            int diff = age - 7;
            Console.WriteLine(diff);
            int prod = age * 7;
            Console.WriteLine(prod);
            decimal quot = age / 7;
            Console.WriteLine(quot);
            int remain = age % 7;
            Console.WriteLine(remain);
        }
        [TestMethod]
        public void MyMovieList()
        {
            //declare and initialize array that holds a collection of 4 or more favorite books, or movies

            string[] movies = { "It Happened on 5th Ave", "Holiday Inn", "Die Hard", "The Cowboys" };

        }
        [TestMethod]
        public void ListofDates()
        {
            //make a list to hold dates include the current date and time
            List<DateTime> listofDates = new List<DateTime>();
            DateTime today = DateTime.Now;
            listofDates.Add(today);
            listofDates.Add(new DateTime(2020, 12, 25));
            listofDates.Add(new DateTime(2020, 11, 26));
            listofDates.Add(new DateTime(2020, 12, 31));
        }
        [TestMethod]
        public void HowMuchSleepmethod()
        {
            Console.WriteLine("How many hours did you sleep last night?");
            int sleep = 7;
            if (sleep >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep");
            }
            else if (sleep >= 8 && sleep < 10)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            else if (sleep > 4 && sleep < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }
        [TestMethod]
        public void SwitchCaseHowWasYourDay()
        {
            // switch case

            string mood = "okay";
            switch (mood)
            {
                case "great":
                    Console.WriteLine("Wow you are having a great day");
                    break;
                case "good":
                    Console.WriteLine("Glad your day is good");
                    break;
                case "ok":
                    Console.WriteLine("Your day is Okay");
                    break;
                case "bad":
                    Console.WriteLine("Sorry your day is bad");
                    break;
                case ":(":
                    Console.WriteLine("Hope your day gets better :(");
                    break;
            }
        }
        [TestMethod]
        public void Supercalifragilisticexpialidocious()
        {
            //Supercalifragilisticexpialidocious written 1 letter at a time

            string supern = "Supercalifragilisticexpialidocious";
            foreach (char letter in supern)
            {
                Console.WriteLine(letter);
            }
        }
        [TestMethod]
        public void INotIandL()
        {
            string[] supern1 = { "S", "u", "p", "e", "r", "c", "a", "l", "i", "f", "r", "a", "g", "i", "l", "i", "s", "t", "i", "c", "e", "x", "p", "i", "a", "l", "i", "d", "o", "c", "i", "o", "u", "s" };

            for (int index = 0; index < 34; index++)
            {
                if (supern1[index] == "i")
                {
                    Console.WriteLine("i");
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
                if (supern1[index] == "l")
                {
                    Console.WriteLine("L");
                }
            }
            int result = supern1.GetLength(0);
            Console.WriteLine(result);
        }
    }
}





 