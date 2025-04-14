using Iterator_MyCode;
using Iterator_MyCode.Models;
using System.Runtime.CompilerServices;
using System.Security.Claims;

class Program
{
    static void Main(string[] args)
    {

        //** Iteratorパターンを用いた実装 ********************************//

        Class class_A = new Class();
        StudentList.Students.ForEach(student => class_A.ApppnedStudent(student));

        // ソート状態が欲しい
        //IEnumerator<Student> classIterator = new ClassIteretor(class_A);
        // ↓ クライアントコードはイテレータを付け替えるだけでOK

        Console.WriteLine($"== Iterator pattern -==============");

        while (true)
        {
            Student student = OrderClassIteretor.Current;
            if (student != null)
            {
                Console.WriteLine($"名前 : {student.Name}");
                Console.WriteLine($"性別 : {student.Gender}");
                Console.WriteLine($"専攻 : {student.Major}");
                Console.WriteLine($"学籍番号 : {student.StudentNumber}");
                Console.WriteLine($"===================================");
            }
            else
            {
                break;
            }
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
