using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.Factory
{
    public class CaseFactory : Factory<BasicComponents.Case>
    {
        public override BasicComponents.Case Create()
        {
            return new BasicComponents.Case()
            {
                Children = new List<AbstractPCComponent>
                {
                    new BasicComponents.HardDrive(500L * 1024 * 1024 * 1024, 7200),
                    new BasicComponents.CDDrive(2400),
                    new BasicComponents.Motherboard()
                    {
                        Children = new List<AbstractPCComponent>
                        {
                            new BasicComponents.CPU(3.6f),
                            new BasicComponents.RAM(8L * 1024 * 1024 * 1024, 2400),
                            new BasicComponents.RAM(8L * 1024 * 1024 * 1024, 2400),
                        }
                    }
                }
            };
        }
    }
}
