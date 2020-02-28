using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.Factory
{
    public abstract class Factory<T>
    {
        public abstract T Create();
    }
}
