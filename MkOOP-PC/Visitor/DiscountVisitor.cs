using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public class DiscountVisitor : IVisitor<AbstractPCComponent>
    {
        public float Discount;

        public DiscountVisitor(float discountperc)
        {
            Discount = discountperc;
        }

        public virtual void Visit(AbstractPCComponent obj)
        {
            if (!(obj is PCComponent newobj)) return;
            newobj.Price -= (newobj.Price * Discount / 100);
        }
    }
}
