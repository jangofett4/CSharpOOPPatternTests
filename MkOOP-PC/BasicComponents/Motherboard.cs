using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.BasicComponents
{
    public class Motherboard : CompositeComponent
    {
        public Motherboard() : base("MSI", 30) { }

        public override string FriendlyToString()
        {
            return $"%1;Motherboard%*; - { Name } - %4;{ Price }%*;$";
        }
    }
}
