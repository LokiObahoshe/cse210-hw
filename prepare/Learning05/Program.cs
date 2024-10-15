using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("William Afton", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathassignment = new MathAssignment("Ash Ketchem", "Substraction", "7.3", "8-19");
        Console.WriteLine();
        Console.WriteLine(mathassignment.GetSummary());
        Console.WriteLine(mathassignment.GetHomeworkList());

        WritingAssignment writingassignment = new WritingAssignment("Mario Mario", "English", "To Kill a Mockingbird");
        Console.WriteLine();
        Console.WriteLine(writingassignment.GetSummary());
        Console.WriteLine(writingassignment.GetWritingInformation());
    }
}