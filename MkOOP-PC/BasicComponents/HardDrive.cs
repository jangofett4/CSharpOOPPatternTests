using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.BasicComponents
{
    public class HardDrive : PCComponent
    {
        public long Size;
        public int RPM;

        public HardDrive(long size, int rpm) : base("Seagate", size / 1024 / 1024 / 1024 / 10) 
        {
            Size = size;
            RPM = rpm;
        }

        public override string FriendlyToString()
        {
            return $"%1;Hard Drive%*; - { Name } - { Size / 1024 / 1024 / 1024 } GiB @ { RPM }rpm - %4;{ Price }%*;$";
        }
    }
}
