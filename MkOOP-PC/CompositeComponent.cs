using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public class CompositeComponent : PCComponent
    {
        public List<AbstractPCComponent> Children { get; set; }

        public CompositeComponent(string name, float price) : base(name, price)
        {
            Children = new List<AbstractPCComponent>();
        }

        public CompositeComponent(string name) : base(name)
        {
            Children = new List<AbstractPCComponent>();
        }

        public void Add(PCComponent c)
        {
            c.Parent = this;
            Children.Add(c);
        }

        public void Add(AbstractPCComponent c)
        {
            // c.Parent = this;
            Children.Add(c);
        }

        public void Add(params PCComponent[] cmps)
        {
            foreach (var c in cmps)
                c.Parent = this;
            Children.AddRange(cmps);
        }

        public void Remove(PCComponent c)
        {
            Children.Remove(c);
            c.Parent = null;
        }
        /*
        public void Aggregate(Action<PCComponent> dg)
        {
            foreach (var c in Children)
                dg(c);
        }
        */
        public override string FriendlyToString()
        {
            return "";
        }

        public override string ToString(int level = 0)
        {
            string lappend = "";
            for (int i = 0; i < level; i++) lappend += "-";

            var sb = new StringBuilder();
            if (level == 0)
                sb.Append($"{ FriendlyToString() } (%11;root%*;) \n");
            else
                sb.Append($"{ lappend } { FriendlyToString() }\n");

            foreach (var c in Children)
                if (c is CompositeComponent)
                    sb.Append($"{ (c as CompositeComponent).ToString(level + 1) }");
                else
                    sb.Append($"{ c.ToString(level + 1) }");
            return sb.ToString();
        }
    }
}
