using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public class DiscountDecorator : AbstractPCComponent
    {
        public float Discount { get; set; }

        public PCComponent Component;
        
        public DiscountDecorator(PCComponent parent, float discount)
        {
            Component = parent;
            Discount = discount;
        }

        public override string FriendlyToString()
        {
            float newprice = Component.Price - ((Component.Price * Discount) / 100);
            string ret = $"{ Component.FriendlyToString() } - { Discount }%% discount = { newprice }$";
            return ret;
        }

        public override string ToString(int level = 0)
        {
            string l = "";
            while (level-- > 0) l += "-";
            return $"{ l } { FriendlyToString() }\n";
        }
    }
}
