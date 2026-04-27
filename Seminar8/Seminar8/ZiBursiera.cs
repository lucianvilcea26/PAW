using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    public class ZiBursiera
    {
        public string Simbol { get; set; }
        public DateTime Data { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }  
        public decimal Low { get; set; }
        public decimal High { get; set; }
        public long Volum { get; set; }
    }
}
