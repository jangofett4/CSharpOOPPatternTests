using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public class MemoryDoublerVisitor : IVisitor<AbstractPCComponent>
    {
        public void Visit(AbstractPCComponent obj)
        {
            if (!(obj is BasicComponents.RAM newobj)) return;
            newobj.Size *= 2;
        }
    }
}
