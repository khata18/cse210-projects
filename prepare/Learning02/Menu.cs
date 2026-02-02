using System;
using System.Collections.Generic;

class Menu
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();

        myResume._name = "Joe";
        bool stop = false;
        while (!stop)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a job");
            Console.WriteLine("2. Display Resume ");
            Console.WriteLine("3. Quit");

            string response = Console.ReadLine();

            if (response == "1")
            {
                Job job1 = new Job();
            job1._company = "Apple";
            job1._jobTitle = "Software Engineer";
            job1._startYear = 2022;
            job1._endYear = 2025;

            myResume._jobs.Add(job1);
            }
            else if (response == "3")
            {
                break;
            }
            else
            {
                myResume.DisplayResume();
            }

        }

    }
}

