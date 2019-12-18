using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2_
{
    internal class BlackPhone : ButtonPhone
    {
        public string Display { get; set; }
        public bool Music { get; set; }
        public bool Games { get; set; }
        public bool Applications { get; set; }
        public string SimCard()
        {
            return "Input in your phone sim card";
        }

        private List<string> contacts = new List<string>();
        private List<string> receivedCall = new List<string>();
        private List<string> missedCall = new List<string>();
        private List<string> canceledCall = new List<string>();
    }

}