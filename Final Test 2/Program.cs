using Final_Test_2;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the ExamResult class
        var examResult = new ExamResult();

        // Create an instance of the Student class, which subscribes to the ResultPublished event
        var student = new Student(examResult);

        // Simulate publishing of an exam result
        examResult.PublishResult("John Doe", 85.5); // Event raised

        // Output:
        // Result published for John Doe: 85.5
        // Take necessary actions...
    }
}
