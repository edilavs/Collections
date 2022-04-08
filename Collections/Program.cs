
using Models;
using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Student student1 = new Student();
            student1.FullName = "Nermin";

            Student student2 = new Student();
            student2.FullName = "Hikmet";
            
            //student.AddExam("English", 87);
            //student.AddExam("Math", 91);
            //student.GetExamAvg();
            //Console.WriteLine(student.No);
            //Console.WriteLine(student.GetExamResult("English"));
            //Console.WriteLine(student.GetExamResult("Chemistry"));
            //Console.WriteLine(student.CheckKey("Biology"));
            Dictionary <string ,double> Exams= new Dictionary<string, double>();
            List<Student> Students = new List<Student>();
            bool check = true;
            string answer = "";
            string fullName = "";
            string noStr = "";
            int no ;
            string key;
            string pointStr;
            double point;
            
            while (check)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.Telebe elave et\n2.Telebeye imtahan elave et\n3.Telebenin bir imtahan balına bax");
                Console.WriteLine("4.Telebeninnin bütün imtahanlarını goster\n5.Telebenin imtahan ortalamasını goster\n6.Telebeden imtahan sil\n0.Proqrami bitir");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("Elave dilecek telebenin adini daxil edin: ");
                            fullName = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(fullName));

                        {
                            Console.WriteLine("Telebenin nomresini daxil edin:");
                            noStr = Console.ReadLine();
                        } while (!int.TryParse(noStr, out no)) ;

                        Student addedStudent = new Student();
                        addedStudent.FullName = fullName;
                        addedStudent.No = no;
                        Students.Add(addedStudent);
                        Console.WriteLine("Telebeler:");
                        foreach (var std in Students)
                        {
                            Console.WriteLine($"{std.FullName}  {std.No}");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Imtahan adi:");
                        key = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Telebenin bali:");
                            pointStr = Console.ReadLine();
                        } while (!double.TryParse(pointStr, out point));
                        do
                        {
                            Console.WriteLine("Telebenin nomresini daxil edin:");
                            noStr = Console.ReadLine();
                        } while (!int.TryParse(noStr, out no));
                        for (int i = 0; i < Students.Count; i++)
                        {
                            if (Students[i].No == no)
                            {
                                Students[i].AddExam(key, point);
                            }
                        }
                       
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Telebenin nomresini daxil edin:");
                            noStr = Console.ReadLine();
                        } while (!int.TryParse(noStr, out no));
                        Console.WriteLine("Imtahanin adi:");
                        key = Console.ReadLine();
                        foreach (var std in Students)
                        {
                            std.GetExamResult(key);
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Telebenin nomresini daxil edin:");
                            noStr = Console.ReadLine();
                        } while (!int.TryParse(noStr, out no));
                        for (int i = 0; i < Students.Count; i++)
                        {
                            if (Students[i].No == no)
                            {
                                foreach (var item in Students[i].Exams)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                        }
                        break;
                    case "5":
                        do
                        {
                            Console.WriteLine("Telebenin nomresini daxil edin:");
                            noStr = Console.ReadLine();
                        } while (!int.TryParse(noStr, out no));
                        foreach (var item in Students)
                        {
                            if (item.No == no)
                            {
                                item.GetExamAvg();
                            }

                        }
                        break;
                    case "6":
                        do
                        {
                            Console.WriteLine("Telebenin nomresini daxil edin:");
                            noStr = Console.ReadLine();
                        } while (!int.TryParse(noStr, out no));
                        Console.WriteLine("Imtahanin adi:");
                        key = Console.ReadLine();
                        foreach (var item in Students)
                        {
                            if (item.No == no)
                            {
                                Students.Remove(item);
                            }
                        }
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin:");
                        break;
                }
            }
            
            

        }
        
    }
}
