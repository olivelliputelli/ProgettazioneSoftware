using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClassLibrary
{
    class Messaggio
    {
        public Data DataMessaggio { get; set; }
        public Orario OrarioMessaggio { get; set; }
        public string TestoMessaggio { get; set; } = "";
        public bool IsRicevuto { get; set; } = false;
    }
}
