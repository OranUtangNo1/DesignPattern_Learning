using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_MyCode_ver2
{
    internal class Class : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();

        public IEnumerator<Student> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
