using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public abstract class PCComponent : AbstractPCComponent
    {
        private float _price;

        public string Name { get; }
        public float Price { get { return _price; } set { _price = value; } }

        public PCComponent Parent { get; set; }

        public PCComponent()
        {
            Name = "";
            Price = 0f;
        }

        public PCComponent(string name)
        {
            Name = name;
            Price = 0f;
        }

        public PCComponent(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public PCComponent(string name, float price, PCComponent parent) : this(name, price)
        {
            Parent = parent;
        }

        public override string FriendlyToString()
        {
            return $"{ Name } - { Price }$";
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
            return sb.ToString();
        }
    }
}
