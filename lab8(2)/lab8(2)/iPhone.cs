using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2_
{
    internal class iPhone: ColorPhone
    {
        public bool Camera { get; set; }
        public bool VoiceHelper { get; set; }

        public string Siri()
        {
            return "Hello, Siri.Voice helper.";
        }
    }
}
