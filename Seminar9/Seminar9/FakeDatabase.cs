using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar9
{
    public static class FakeDatabase
    {
        public static List<IntrareJurnal> Intrari = new List<IntrareJurnal>
    {
        new IntrareJurnal
        {
            Data        = new DateTime(2025, 3, 10),
            Titlu       = "Prima zi de primăvară",
            Continut    = "Azi a ieșit soarele pentru prima dată după luni întregi de gri. " +
                          "Am ieșit la plimbare prin parc și am simțit că totul poate fi bine.",
            Dispozitie  = Dispozitie.Fericit,
            EstePrivata = false
        },
        new IntrareJurnal
        {
            Data        = new DateTime(2025, 4, 22),
            Titlu       = "O zi obișnuită",
            Continut    = "Nimic special azi. Am lucrat, am mâncat, am citit puțin înainte de culcare. " +
                          "Uneori normalul e de ajuns.",
            Dispozitie  = Dispozitie.Neutru,
            EstePrivata = false
        },
        new IntrareJurnal
        {
            Data        = new DateTime(2025, 5, 5),
            Titlu       = "Vești proaste",
            Continut    = "Am aflat că proiectul pe care l-am muncit luni întregi a fost anulat. " +
                          "Greu de acceptat. Am nevoie de timp să procesez.",
            Dispozitie  = Dispozitie.Trist,
            EstePrivata = false
        },
        new IntrareJurnal
        {
            Data        = new DateTime(2025, 6, 18),
            Titlu       = "Gânduri personale",
            Continut    = "Am luat o decizie importantă legată de viitorul meu. Nu sunt pregătit " +
                          "să o împărtășesc cu nimeni deocamdată.",
            Dispozitie  = Dispozitie.Entuziasmat,
            EstePrivata = true
        },
        new IntrareJurnal
        {
            Data        = new DateTime(2025, 7, 2),
            Titlu       = "Vacanță meritată",
            Continut    = "Prima zi la munte. Aerul curat, liniștea, și o carte bună. " +
                          "Exact ce aveam nevoie după ultimele luni agitate.",
            Dispozitie  = Dispozitie.Fericit,
            EstePrivata = false
        }
    };
    }
}
