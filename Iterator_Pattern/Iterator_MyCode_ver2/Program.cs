using Data;
using System.Linq;

namespace Iterator_MyCode_ver2
{
    class Program
    {
        static void Main(string[] args)
        {

            //** Iteratorパターンを用いた実装 ********************************//

            // 生徒データの作成
            Class class_A = new Class();
            StudentList.Students.ForEach(student => class_A.ApppnedStudent(student));

            Console.WriteLine($"== Iterator pattern -==============");

            // クラス側にカスタムソートした、IEnumrableを返すメソッドを実装しておけば、クライアントコードの変更量が少なくなる
            var sortedStudentList = class_A.Where<Student>(student => student.Gender == Gender.Male).ToList();
            foreach (var student in sortedStudentList) 
            {
                Console.WriteLine($"名前 : {student.Name}");
                Console.WriteLine($"性別 : {student.Gender}");
                Console.WriteLine($"専攻 : {student.Major}");
                Console.WriteLine($"学籍番号 : {student.StudentNumber}");
                Console.WriteLine($"===================================");
            }
            Console.WriteLine($"");


            //****************************************************************//


            //** 通常の実装 ************************************************//

            Console.WriteLine($"== Not Iterator pattern ==============");
            IList<Student> studentList = new List<Student>();
            StudentList.Students.ForEach(student => studentList.Add(student));

            foreach (var student in studentList)
            {
                Console.WriteLine($"名前 : {student.Name}");
                Console.WriteLine($"性別 : {student.Gender}");
                Console.WriteLine($"専攻 : {student.Major}");
                Console.WriteLine($"学籍番号 : {student.StudentNumber}");
                Console.WriteLine($"===================================");
            }

            //****************************************************************//

        }
    }
}
