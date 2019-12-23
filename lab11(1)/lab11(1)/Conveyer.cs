using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_1_
{
    class Conveyer
    {



        public void SizesRemoved(Product productChar)
        {
            productChar.SizesRemoved = true;
        }

        public void CutOff(Product productChar)
        {
            productChar.CutOff = true;
        }

        public void Sharpened(Product productChar)
        {
            productChar.Sharpened = true;
        }

        public void CutTheThread(Product productChar)
        {
            productChar.CutTheThread = true;
        }

        public void Drilled(Product productChar)
        {
            productChar.Drilled = true;
        }

        public void Painted(Product productChar)
        {
            productChar.Painted = true;
        }

        public void Tested(Product productChar)
        {
        productChar.Tested = true;
        }
        public void Wrapped(Product productChar)
        {
        productChar.Wrapped = true;
        }
   








}
}
