using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public interface IVisitor<T>
    {
        public void Visit(T obj);
    }
}
