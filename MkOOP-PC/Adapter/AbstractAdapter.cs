using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public abstract class Adapter<T> : AbstractPCComponent where T : AbstractPCComponent
    {
        public T Adaptee;
        
        public Adapter(T adaptee)
        {
            Adaptee = adaptee;
        }

        public abstract void Request();

        public override string ToString(int level = 0) => Adaptee.ToString(level);
        public override string FriendlyToString() => Adaptee.FriendlyToString();
    }
}
