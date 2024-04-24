using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Test_2
{
    internal class Student
    {
        public Student(ExamResult examResult)
        {
            examResult.ResultPublished += HandleResultPublished;
        }

        private void HandleResultPublished(object sender, ExamResultEventArgs e)
        {
            Console.WriteLine($"Result published for {e.StudentName}: {e.MarksObtained}");
            Console.WriteLine("Take necessary actions...");
        }
    }
}
