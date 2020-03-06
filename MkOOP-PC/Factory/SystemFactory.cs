using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.Factory
{
    public class SystemFactory : Factory<BasicComponents.PCSystem>
    {
        public override BasicComponents.PCSystem Create()
        {
            return new BasicComponents.PCSystem()
            {
                Children = new List<AbstractPCComponent>
                {
                    // Add 3 monitors
                    new BasicComponents.Monitor(1920, 1080, 59.9f),
                    new BasicComponents.Monitor(1920, 1080, 59.9f),
                    new BasicComponents.Monitor(1920, 1080, 59.9f),
                    // Add a case, from factory
                    new IndexAdapter<BasicComponents.Case>(new CaseFactory().Create())
                }
            };
        }
    }
}
