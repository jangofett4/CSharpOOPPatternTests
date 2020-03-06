using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public abstract class AbstractPCComponent
    {
        public abstract string FriendlyToString();

        public abstract string ToString(int level = 0);
        
        public virtual void Accept(IVisitor<AbstractPCComponent> listener)
        {
            listener.Visit(this);
        }
    }
}