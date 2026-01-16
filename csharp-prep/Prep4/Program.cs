using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0, sum = 0, largest = 0;
        List<int> numberList = new List<int>();
        do
        {   
            

            Console.Write("Enter number: ");
            string inputNumber = Console.ReadLine();
            number = int.Parse(inputNumber);
            if (number != 0)
            {
                numberList.Add(number);
            }

            
            
        } while (number != 0);

        foreach (int eachNum in numberList)
        {
            sum = sum + eachNum;

            if (eachNum >= largest)
            {
                largest = eachNum;
            }
        }

       
        double avg = (double)sum / (double)numberList.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}