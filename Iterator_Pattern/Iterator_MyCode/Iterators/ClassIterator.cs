using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_MyCode.Models;

namespace Iterator_MyCode 
{
    public class ClassIteretor : IAggrigate<Student>
    {
        IClass _class { get; }
        public int Index { get; private set; }

        public Object Current => this._class.GetStudent(Index);

        Student IEnumerator<Student>.Current => this._class.GetStudent(Index);

        public ClassIteretor(IClass _class)
        {
            this._class = _class;
            this.Index = 0;
        }

        public bool MoveNext()
        {
            if (this._class.Last > this.Index + 1)
            {
                Index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset() 
        {
            this.Index = 0;
        }

        public void Dispose()
        {
            // リソースの確保無し
            ;
        }
    }


    public class OrderClassIteretor : IAggrigate<Student>
    {
        private Class _class;
        private readonly List<Student> _sortedStudents = new List<Student>();

        public int Index { get; private set; }

        public Student Current => this.GetCurrent();

        object IEnumerator.Current => this.Current;

        public OrderClassIteretor(Class _class)
        {
            this._class = _class;
            this.Index = 0;

            for(int i = 0; this._class.Last > i; i++) 
            {
                _sortedStudents.Add(this._class.GetStudent(i));
            }
            _sortedStudents.Sort((a, b) => a.Name.CompareTo(b.Name));
        }

        public bool MoveNext()
        {
            if (this._class.Last > Index)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this.Index = 0;
        }

        public void Dispose()
        {
            ;
        }

        private Student GetCurrent() 
        {
            if (MoveNext())
            {
                var student = this._sortedStudents[Index];
                Index++;
                return student;
            }
            return null;
        }
    }
}
