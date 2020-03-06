using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public class IndexAdapter<T> : Adapter<T> where T : CompositeComponent
    {
        public T BaseComponent;

        public AbstractPCComponent this[int index]
        {
            get { return BaseComponent.Children[index]; }
            set { BaseComponent.Children[index] = value; }
        }

        public List<AbstractPCComponent> this[string elem]
        {
            get
            {
                var ret = new List<AbstractPCComponent>();
                foreach (var c in BaseComponent.Children)
                    if ((c is PCComponent comp))
                        if (comp.Name == elem)
                            ret.Add(comp);
                return ret;
            }
        }

        public IndexAdapter(T comp) : base(comp)
        {
            BaseComponent = comp;
        }

        public override void Request()
        {
            throw new NotImplementedException();
        }
    }
}
