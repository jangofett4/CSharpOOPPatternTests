using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.BasicComponents
{
    public class Case : CompositeComponent
    {
        public Case() : base("NZXT", 20) { }

        public override string FriendlyToString()
        {
            return $"%1;Case%*; - { Name } - %4;{ Price }%*;$";
        }
    }
}
