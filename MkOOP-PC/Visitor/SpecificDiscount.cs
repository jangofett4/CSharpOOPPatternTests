using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public class SpecificDiscount<T> : DiscountVisitor, IVisitor<AbstractPCComponent> where T : PCComponent
    {
        public SpecificDiscount(float discount) : base(discount) { }

        public override void Visit(AbstractPCComponent obj)
        {
            if (!(obj is T newobj)) return;
            newobj.Price -= (newobj.Price * Discount / 100);
        }
    }
}
