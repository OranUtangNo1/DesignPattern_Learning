using Iterator_MyCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_MyCode
{
    public static class StudentList
    {
        //　生徒リスト
        public static List<Student> Students = new List<Student>()
        {
            new Student("Takuto",Gender.Male,Major.ComputerScience,"A001"),
            new Student("Kengo",Gender.Male,Major.Mathematics,"A002"),
            new Student("Yutaro",Gender.Male,Major.Chemistry,"A003"),
        };
    }
}
