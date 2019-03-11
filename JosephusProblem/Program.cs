using System;
using System.Collections.Generic;

namespace JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are trapped in a cave?");

            var numberOfPeople = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is the killing interval?");

            var killingInterval = Int32.Parse(Console.ReadLine());
            
            LastPersonStanding(numberOfPeople, killingInterval);

            Console.WriteLine($"The last man standing is number {LastPersonStanding(numberOfPeople, killingInterval)}.");

            Console.ReadKey();
        }

        static int LastPersonStanding(int numberOfPeople, int killingInterval)
        {
            var listOfPeople = new List<int>();

            for (var i = 1; i <= numberOfPeople; i++)
            {
                listOfPeople.Add(i);
            }

            do
            {
                int killCounter = 1;
                for (var i = 0; i < listOfPeople.Count; i++)
                {
                    if (killCounter == killingInterval)
                    {
                        listOfPeople.RemoveAt(0);
                        killCounter = 1;
                    }
                    else
                    {
                        listOfPeople.Add(listOfPeople[0]);
                        listOfPeople.RemoveAt(0);
                        killCounter++;
                        i--;
                    }
                }
            }
            while (listOfPeople.Count > 1);
    
            return listOfPeople[0];
        }
    }
}
