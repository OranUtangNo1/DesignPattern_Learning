using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_MyCode.Models;

namespace Iterator_MyCode 
{
    public class ClassIteretor : IEnumerator<Student>
    {
        Class Class { get; }
        public int Index { get; private set; }

        public Student Current => Class.GetStudent(Index);

        public ClassIteretor(Class _class)
        {
            this.Class = _class;
            this.Index = 0;
        }

        public bool HashNext()
        {
            if (this.Class.Last > this.Index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Object Next()
        {
            var student = this.Class.GetStudent(this.Index);
            this.Index++;
            return student;
        }
    }
}
