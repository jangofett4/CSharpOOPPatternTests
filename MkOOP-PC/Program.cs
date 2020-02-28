using System;

namespace MkOOPPC
{
    class Program
    {
        public static BasicComponents.PCSystem PCSystem;
        static void Main(string[] args)
        {
            PCSystem = new Factory.SystemFactory().Create();
            SuperKonsole.SuperKonsole.Write(PCSystem.ToString());
        }
    }
}
