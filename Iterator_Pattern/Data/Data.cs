using System;
using System.Collections.Generic;
using System.Reflection;

namespace Data
{
    public enum Gender
    {
        Male,
        Female,
        Other,
    }

    public enum Major
    {
        ComputerScience,   // コンピュータサイエンス
        Mathematics,       // 数学
        Physics,           // 物理学
        Chemistry,         // 化学
    }

    public static class StudentList
    {
        //　生徒リスト
        public static List<Student> Students = new List<Student>()
        {
            new Student("Takuto",Gender.Male,Major.ComputerScience,"A001"),
            new Student("Kengo",Gender.Male,Major.Mathematics,"A002"),
            new Student("Yutaro",Gender.Male,Major.Chemistry,"A003"),
            new Student("Suzuki",Gender.Female,Major.Physics,"A004"),
            new Student("Takeshi",Gender.Other,Major.Mathematics,"A005"),
        };
    }

    public class Student
    {
        public string Name { get; }
        public Gender Gender { get; }
        public Major Major { get; }
        public string StudentNumber { get; }

        public Student(string name, Gender gender, Major major, string studentNumber)
        {
            Name = name;
            Gender = gender;
            Major = major;
            StudentNumber = studentNumber;
        }
    }
}
