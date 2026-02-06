using System;

class Program
{
    static void Main(string[] args)
    {
    //     Console.WriteLine("Hello Learning03 World!");

    //     Fraction firstFraction = new Fraction();
    //     Fraction secondFraction = new Fraction(6);
    //     Fraction thirdFraction = new Fraction(6,7);

    //     Console.WriteLine(firstFraction.GetTop());
    //     Console.WriteLine(firstFraction.GetBottom());
    //     Console.WriteLine(firstFraction.GetFractionString());
    //     Console.WriteLine(firstFraction.GetDecimalValue());

    //    secondFraction.SetTop(5);
    //     Console.WriteLine(secondFraction.GetTop());
    //     Console.WriteLine(secondFraction.GetFractionString());
    //     Console.WriteLine(secondFraction.GetDecimalValue());

    //     thirdFraction.SetTop(3);
    //     Console.WriteLine(thirdFraction.GetTop());
    //     thirdFraction.SetBottom(4);
    //     Console.WriteLine(thirdFraction.GetBottom());
    //     Console.WriteLine(thirdFraction.GetFractionString());
    //     Console.WriteLine(thirdFraction.GetDecimalValue());

    //     thirdFraction.SetTop(1);
    //     Console.WriteLine(thirdFraction.GetTop());
    //     thirdFraction.SetBottom(3);
    //     Console.WriteLine(thirdFraction.GetBottom());
    //     Console.WriteLine(thirdFraction.GetFractionString());
    //     Console.WriteLine(thirdFraction.GetDecimalValue());


        Fraction newFraction = new Fraction ();

        int count = 0;

        while (count < 20)
        {
            
            count += 1;
            Random randomGeneratorTop = new Random();
            int randomTop = randomGeneratorTop.Next(1,10);

            Random randomGeneratorBottom = new Random();
            int randomBottom = randomGeneratorTop.Next(1,10);

            newFraction.SetTop(randomTop);
            newFraction.SetBottom(randomBottom);

            Console.WriteLine($"Fraction {count}: string: {newFraction.GetFractionString()} Number: {newFraction.GetDecimalValue()}");
        }
    }
}

