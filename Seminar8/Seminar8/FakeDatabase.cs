using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    public static class FakeDatabase
    {
        public static List<Companie> Companii = new List<Companie>
        {
            new Companie { Simbol = "TLV", Nume = "Banca Transilvania", Sector = "Financiar" },
            new Companie { Simbol = "SNP", Nume = "OMV Petrom", Sector = "Energie" },
            new Companie { Simbol = "TGN", Nume = "Transgaz", Sector = "Energie" }
        };

        public static List<ZiBursiera> Zile = new List<ZiBursiera>
        {
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 1),  Open = 25.10m, High = 25.60m, Low = 24.90m, Close = 25.40m, Volum = 4820000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 4),  Open = 25.40m, High = 25.90m, Low = 25.20m, Close = 25.75m, Volum = 5140000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 5),  Open = 25.75m, High = 26.10m, Low = 25.50m, Close = 25.60m, Volum = 3970000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 6),  Open = 25.60m, High = 25.80m, Low = 25.10m, Close = 25.20m, Volum = 6310000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 7),  Open = 25.20m, High = 25.50m, Low = 24.80m, Close = 25.45m, Volum = 4550000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 8),  Open = 25.45m, High = 26.00m, Low = 25.40m, Close = 25.90m, Volum = 7230000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 11), Open = 25.90m, High = 26.30m, Low = 25.70m, Close = 26.20m, Volum = 5880000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 12), Open = 26.20m, High = 26.50m, Low = 25.90m, Close = 26.00m, Volum = 4120000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 13), Open = 26.00m, High = 26.10m, Low = 25.40m, Close = 25.50m, Volum = 6740000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 14), Open = 25.50m, High = 25.70m, Low = 25.10m, Close = 25.30m, Volum = 3650000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 15), Open = 25.30m, High = 25.80m, Low = 25.20m, Close = 25.70m, Volum = 4980000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 18), Open = 25.70m, High = 26.20m, Low = 25.60m, Close = 26.10m, Volum = 5430000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 19), Open = 26.10m, High = 26.40m, Low = 25.80m, Close = 25.85m, Volum = 3890000 },
            new ZiBursiera { Simbol = "TLV", Data = new DateTime(2024, 3, 20), Open = 25.85m, High = 26.30m, Low = 25.75m, Close = 26.20m, Volum = 6110000 },

            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 1),  Open = 0.548m, High = 0.561m, Low = 0.542m, Close = 0.556m, Volum = 112400000 },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 4),  Open = 0.556m, High = 0.568m, Low = 0.550m, Close = 0.562m, Volum = 98700000  },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 5),  Open = 0.562m, High = 0.570m, Low = 0.555m, Close = 0.558m, Volum = 134500000 },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 6),  Open = 0.558m, High = 0.562m, Low = 0.545m, Close = 0.548m, Volum = 176200000 },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 7),  Open = 0.548m, High = 0.556m, Low = 0.542m, Close = 0.554m, Volum = 88300000  },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 8),  Open = 0.554m, High = 0.565m, Low = 0.550m, Close = 0.563m, Volum = 145600000 },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 11), Open = 0.563m, High = 0.572m, Low = 0.558m, Close = 0.570m, Volum = 119800000 },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 12), Open = 0.570m, High = 0.575m, Low = 0.561m, Close = 0.564m, Volum = 92100000  },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 13), Open = 0.564m, High = 0.566m, Low = 0.550m, Close = 0.552m, Volum = 201300000 },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 14), Open = 0.552m, High = 0.558m, Low = 0.546m, Close = 0.555m, Volum = 78900000  },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 15), Open = 0.555m, High = 0.564m, Low = 0.551m, Close = 0.561m, Volum = 103400000 },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 18), Open = 0.561m, High = 0.569m, Low = 0.557m, Close = 0.567m, Volum = 126700000 },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 19), Open = 0.567m, High = 0.571m, Low = 0.558m, Close = 0.560m, Volum = 89500000  },
            new ZiBursiera { Simbol = "SNP", Data = new DateTime(2024, 3, 20), Open = 0.560m, High = 0.574m, Low = 0.558m, Close = 0.572m, Volum = 154200000 },

            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 1),  Open = 388.00m, High = 393.50m, Low = 385.00m, Close = 391.00m, Volum = 52400  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 4),  Open = 391.00m, High = 396.00m, Low = 389.50m, Close = 394.50m, Volum = 67800  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 5),  Open = 394.50m, High = 397.00m, Low = 391.00m, Close = 392.00m, Volum = 44100  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 6),  Open = 392.00m, High = 393.50m, Low = 385.50m, Close = 387.00m, Volum = 88600  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 7),  Open = 387.00m, High = 390.00m, Low = 383.00m, Close = 389.00m, Volum = 61300  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 8),  Open = 389.00m, High = 395.50m, Low = 388.00m, Close = 394.00m, Volum = 79500  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 11), Open = 394.00m, High = 400.00m, Low = 392.50m, Close = 398.50m, Volum = 95200  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 12), Open = 398.50m, High = 401.00m, Low = 394.00m, Close = 395.50m, Volum = 48700  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 13), Open = 395.50m, High = 396.50m, Low = 386.00m, Close = 388.00m, Volum = 102300 },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 14), Open = 388.00m, High = 391.00m, Low = 384.50m, Close = 390.00m, Volum = 57600  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 15), Open = 390.00m, High = 395.00m, Low = 388.50m, Close = 393.50m, Volum = 71900  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 18), Open = 393.50m, High = 399.00m, Low = 392.00m, Close = 397.00m, Volum = 83400  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 19), Open = 397.00m, High = 400.50m, Low = 393.50m, Close = 394.50m, Volum = 46200  },
            new ZiBursiera { Simbol = "TGN", Data = new DateTime(2024, 3, 20), Open = 394.50m, High = 401.50m, Low = 393.00m, Close = 400.00m, Volum = 76800  }
        };
    }
}
