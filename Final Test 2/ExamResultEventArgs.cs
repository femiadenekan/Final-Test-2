using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Test_2
{
    internal class ExamResultEventArgs : EventArgs
    {
        public string StudentName { get; }
        public double MarksObtained { get; }

        public ExamResultEventArgs(string studentName, double marksObtained)
        {
            StudentName = studentName;
            MarksObtained = marksObtained;
        }
    }
}
