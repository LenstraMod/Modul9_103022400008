using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400008
{
    public class Config
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> Method { get; set; }
        public Confirmation confirm { get; set; }

        public Config() { }

        public Config(string lang, Transfer transfer, List<String> Method, Confirmation confirm) {
            this.lang = lang;
            this.transfer = transfer;
            this.Method = Method;
            this.confirm = confirm;
        }
    }
}
