using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC
{
    public class Service
    {
        public float ServicePrice;

        public Service(float orig)
        {
            ServicePrice = orig + 13.0f;
        }
    }
}
