using Data;
using System.Collections;

namespace Iterator_MyCode_ver2
{
    //IEnumerable<Student>を継承→Classオブジェクトに対してforeachやLINQが利用可能
    internal class Class : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();

        public void ApppnedStudent(Student student)
        {
            this.students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach(var _student in students)
            {
                // yield returnすることで studentsの全ての要素をEnumeratorとして返す
                yield return _student;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
