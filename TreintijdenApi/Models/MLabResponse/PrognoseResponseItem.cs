using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models.MLabResponse
{
    public class PrognoseResponseItem
    {
        public int Verwachting { get; set; }
        public string Station { get; set; }
        public int Capaciteit { get; set; }
        public string Classifiction { get; set; }
        public int Prognose { get; set; }
    }
}
