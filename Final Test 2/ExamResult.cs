using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Test_2
{
    public class ExamResult
    {
        public event EventHandler<ExamResultEventArgs> ResultPublished;

        public void PublishResult(string studentName, double marksObtained)
        {
            OnResultPublished(new ExamResultEventArgs(studentName, marksObtained));
        }

        protected virtual void OnResultPublished(ExamResultEventArgs e)
        {
            ResultPublished?.Invoke(this, e);
        }
    }
}

