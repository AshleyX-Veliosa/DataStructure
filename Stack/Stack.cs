using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public interface Stack
    {
        void push(object e);
        object pop();
        object peek();
        bool isEmpty();
        int size();
    }
}
