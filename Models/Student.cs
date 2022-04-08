using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student
    {
        public Student()
        {
            TotalCount++;
            No = TotalCount;
        }
        public static int TotalCount;
        public int No { get; set; }
        public string FullName { get; set; }
        public Dictionary<string, double> Exams = new Dictionary<string, double>();
        public void AddExam(string examName,double point)
        {
            if (!CheckKey(examName))
            {
                Exams.Add(examName, point);
            }

        }
        public double GetExamResult(string examName)
        {
            if (CheckKey(examName))
            {
                foreach (var item in Exams)
                {
                    if (item.Key == examName)
                    {
                        return item.Value;
                    }
                }
            }
            return 0;
        }
        public double GetExamAvg()
        {
            double sum = 0;
            double avg = 0;
            
                foreach (var item in Exams)
                {
                    sum += item.Value;
                }
                avg = sum / Exams.Count;
            return avg;
        }
        public bool CheckKey(string examName)
        {
            foreach (var item in Exams )
            {
                if (item.Key == examName)
                    return true;
            }

            return false;
        }
    }
}
