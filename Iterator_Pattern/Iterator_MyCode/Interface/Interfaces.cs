using Iterator_MyCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_MyCode
{
    public interface IAggrigate<T> : IEnumerator<T>
    {
        //T GetCurrent();
    }
}
