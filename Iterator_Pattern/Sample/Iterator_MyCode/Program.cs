using Iterator_MyCode;
using Iterator_MyCode.Models;

class Program
{
    static void Main(string[] args) 
    {
        IClass class_A = new Class();
        StudentList.Students.ForEach(student => class_A.ApppnedStudent(student));
        IIterator classRoomIterator = class_A.Iterator();

        while (classRoomIterator.HashNext())
        {
            Console.WriteLine($"###################################");
            var student = (Student)classRoomIterator.Next();
            Console.WriteLine($"名前 : {student.Name}");
            Console.WriteLine($"性別 : {student.Gender}");
            Console.WriteLine($"専攻 : {student .Major}");
            Console.WriteLine($"学籍番号 : {student.StudentNumber}");
        }
    }



}
