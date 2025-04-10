using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_MyCode
{
    public interface IIterator
    {
        bool HashNext();
        object Next();
    }

    public interface IAggrigate
    {
        IIterator Iterator();
    }
}
