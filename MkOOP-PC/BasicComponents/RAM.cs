using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.BasicComponents
{
    public class RAM : PCComponent
    {
        public long Size;
        public float Speed;

        public RAM(long size, float speed) : base("Kingstone", (size / 1024 / 1024 / 1024) + 25)
        {
            Size = size;
            Speed = speed;
        }

        public override string FriendlyToString()
        {
            return $"%1;Memory%*; - { Name } - { Size / 1024 / 1024 / 1024 } GiB - { Speed } Mhz - %4;{ Price }%*;$";
        }
    }
}
