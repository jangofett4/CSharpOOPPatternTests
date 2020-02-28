using System;
using System.Collections.Generic;
using System.Text;

namespace MkOOPPC.BasicComponents
{
    public class Monitor : PCComponent
    {
        public int Width;
        public int Height;
        public float RefreshRate;

        public Monitor(int w, int h, float hz) : base("LG", (w * h / 100000) + hz) 
        {
            Width = w;
            Height = h;
            RefreshRate = hz;
        }

        public override string FriendlyToString()
        {
            return $"%1;Monitor%*; - { Name } - { Width }x{ Height }@{ RefreshRate }Hz - %4;{ Price }%*;$";
        }
    }
}
