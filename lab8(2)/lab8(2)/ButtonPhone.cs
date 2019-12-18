using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2_
{
    internal class ButtonPhone : OldPhone
    {
        public string Button { get; set; }
        public string ClickOnButton()
        {
            return "Click";
        }
               
    }
}
