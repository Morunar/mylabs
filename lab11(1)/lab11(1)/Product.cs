using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_1_
{
    public class Product
    {
        public bool SizesRemoved{ get; set; }
        public bool CutOff { get; set; }
        public bool Sharpened { get; set; }
        public bool CutTheThread { get; set; }
        public bool Drilled { get; set; }
        public bool Painted { get; set; }
        public bool Tested { get; set; }
        public bool Wrapped { get; set; }
        public string ShowProperties()
        {
            return $"SizesRemoved-{SizesRemoved}\n" +
                $"CutOff-{CutOff}\n" +
                $"Sharpened-{Sharpened}\n" +
                $"CutTheThread-{CutTheThread}\n" +
                $"Drilled-{Drilled}\n" +
                $"Painted-{Painted}\n" +
                $"Tested-{Tested}\n" +
                $"Wrapped-{Wrapped}";
        }


    }
}
