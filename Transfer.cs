using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Modul9_103022400008
{
    public class Transfer
    {
        public int threshold { get; set; }
        public int low { get; set; }
        public int high { get; set; }

        public Transfer() { }

        public Transfer(int threshold, int low, int high) { 
            this.threshold = threshold;
            this.low = low;
            this.high = high;
        }
    }
}
