using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_MyCode.Models;

namespace Iterator_MyCode
{
    public interface IClass 
    {
        void ApppnedStudent(Student student);

        void RemoveStudent(Student student);

        Student GetStudent(int index);

    }

    public class Class : IEnumerable<Student>, IClass
    {
        IList<Student> students = new List<Student>();

        public int Last { get; private set; }

        public void ApppnedStudent(Student student)
        {
            this.students.Add(student);
            this.Last++;
        }

        public void RemoveStudent(Student student)
        {
            //未実装
        }

        public Student GetStudent(int index)
        {
            return this.students[index];
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return new ClassIteretor(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }
    }
}
