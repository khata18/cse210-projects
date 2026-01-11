using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input_grade = Console.ReadLine();
        int grade = int.Parse(input_grade);

        if (grade >= 90)
        {
            int final = grade % 10;
            if (final < 3)
            {
                string letter = "A-";
                Console.WriteLine($"{letter}");
            }
            else
            {
                string letter = "A";
                Console.WriteLine($"{letter}");
            }
            Console.WriteLine("Congratulations! You have passed the course!");

        }
        else if (grade >= 80)
        {
            int final = grade % 10;
            if (final >= 7)
            {
                string letter = "B+";
                Console.WriteLine($"{letter}");
            }
            else if (final < 3)
            {
                string letter = "B-";
                Console.WriteLine($"{letter}");
            }
            else
            {
                string letter = "B";
                Console.WriteLine($"{letter}");
            }
            Console.WriteLine("Congratulations! You have passed the course!");

        }
        else if (grade >= 70)
        {
            int final = grade % 10;
            if (final >= 7)
            {
                string letter = "C+";
                Console.WriteLine($"{letter}");
            }
            else if (final < 3)
            {
                string letter = "C-";
                Console.WriteLine($"{letter}");
            }
            else
            {
                string letter = "C";
                Console.WriteLine($"{letter}");
            }
            Console.WriteLine("Congratulations! You have passed the course!");

        }
        else if (grade >= 60)
        {
            int final = grade % 10;
            if (final >= 7)
            {
                string letter = "D+";
                Console.WriteLine($"{letter}");
            }
            else if (final < 3)
            {
                string letter = "D-";
                Console.WriteLine($"{letter}");
            }
            else
            {
                string letter = "D";
                Console.WriteLine($"{letter}");
            }
            Console.WriteLine("Congratulations! You have passed the course!");

        }
        else
        {
            string letter = "F";
            Console.WriteLine($"{letter}");
            Console.WriteLine("You have failed the course. Please try again.");
        }
    }
}