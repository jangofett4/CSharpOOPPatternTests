using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.BasicComponents
{
    public class CPU : PCComponent
    {
        public float Speed;

        public CPU(float speed) : base("AMD Ryzen", speed * 20)
        {
            Speed = speed;
        }

        public override string FriendlyToString()
        {
            return $"%1;CPU%*; - { Name } - { Speed } Ghz - %4;{ Price }%*;$";
        }
    }
}
