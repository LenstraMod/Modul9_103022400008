using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Modul9_103022400008
{
    public class Confirmation
    {
        public string en;
        public string id;

        public Confirmation() { }

        public Confirmation(string en, string id) { 
            this.en = en;
            this.id = id;
        }
    }
}
