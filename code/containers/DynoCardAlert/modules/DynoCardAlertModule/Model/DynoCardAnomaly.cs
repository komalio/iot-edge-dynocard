using System;
using System.Collections.Generic;

namespace DynoCardAlertModule.Model
{
    public class DynoCardAnomalyResult
    {
        public string DynoCardId { get; set; }
        public DateTime DynoCardTimestamp { get; set; }
        public int Result { get; set; }
    }
}