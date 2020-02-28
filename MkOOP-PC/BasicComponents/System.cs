using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.BasicComponents
{
    public class PCSystem : CompositeComponent
    {
        public PCSystem() : base("PC") { }

        public override string FriendlyToString()
        {
            return $"%5;PC%*; - %9;{ Count<Monitor>() }%*; monitors, %9;{ Count<Case>() }%*; cases";
        }

        public int Count<T>() where T : PCComponent
        {
            int t = 0;
            foreach (var c in Children)
                if (c is T)
                    t++;
            return t;
        }
    }
}
