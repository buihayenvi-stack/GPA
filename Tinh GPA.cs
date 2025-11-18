using System;
using System.Collections.Generic;
using System.Linq;

class Course
{
    public string Name { get; set; }
    public int Credit { get; set; }
    public int Grade { get; set; }

    public Course(string name, int credit, int grade)
    {
        Name = name;
        Credit = credit;
        Grade = grade;
    }
}

class Program
{
    static void Main()
    {
        string studentName = "Sophia Johnson";
        int gradeA = 4;
        int gradeB = 3;

        // Danh sách các khóa học
        List<Course> courses = new List<Course>()
        {
            new Course("English 101", 3, gradeA),
            new Course("Algebra 101", 3, gradeB),
            new Course("Biology 101", 4, gradeB),
            new Course("Computer Science I", 4, gradeB),
            new Course("Psychology 101", 3, gradeA)
        };

        // Tính tổng tín chỉ và tổng điểm
        int totalCreditHours = courses.Sum(c => c.Credit);
        int totalGradePoints = courses.Sum(c => c.Credit * c.Grade);

        // Tính GPA
        decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

        // In thông tin học viên và bảng điểm
        Console.WriteLine($"Student: {studentName}\n");
        Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Name}\t\t{course.Grade}\t\t{course.Credit}");
        }

        Console.WriteLine($"\nTotal Credit Hours: {totalCreditHours}");
        Console.WriteLine($"Total Grade Points: {totalGradePoints}");
        Console.WriteLine($"Final GPA:\t\t\t {gradePointAverage:F2}");
    }
}
