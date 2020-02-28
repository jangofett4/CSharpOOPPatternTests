using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.BasicComponents
{
    public class CDDrive : PCComponent
    {
        public int RPM;

        public CDDrive(int rpm) : base("LG", rpm / 1000 + 5) 
        {
            RPM = rpm;
        }

        public override string FriendlyToString()
        {
            return $"%1;CD Drive%*; - { Name } - { RPM }rpm - %4;{ Price }%*;$";
        }
    }
}
