using System;
using Console = SuperKonsole.SuperKonsole;

namespace MkOOPPC
{
    class Program
    {
        public static BasicComponents.PCSystem PCSystem;
        static void Main(string[] args)
        {
            PCSystem = new Factory.SystemFactory().Create();

            var sysadapter = new IndexAdapter<BasicComponents.PCSystem>(PCSystem);

            var lgs = sysadapter["LG"];
            foreach (var lg in lgs)
                Console.WriteLine("Name: {}, price: {}", (lg as PCComponent).Name, (lg as PCComponent).Price);

            Console.WriteLine("Entire system before 10 percent monitor discount visitor");
            Console.Write(PCSystem.ToString());

            Console.WriteLine("");
            Console.WriteLine("Entire system after 10 percent monitor discount and memory doubler visitor");
            PCSystem.Accept(new SpecificDiscount<BasicComponents.Monitor>(10));
            PCSystem.Accept(new MemoryDoublerVisitor());
            Console.Write(PCSystem.ToString());
        }
    }
}
