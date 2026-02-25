using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("Kosei", "Math");
        // Console.WriteLine(assignment.GetSummary());

        MathAssignment ma = new MathAssignment("Kosei", "Math", "Section 7.3", "Problems 8-19");
        Console.WriteLine(ma.GetHomeworkList());

        WritingAssignment wa = new WritingAssignment("Kosei", "Japan History", "Age of Edo");
        Console.WriteLine(wa.GetWritingInformation());

    }
}