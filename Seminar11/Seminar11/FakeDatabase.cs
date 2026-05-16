using System;
using System.Collections.Generic;

namespace Seminar11
{
    public static class FakeDatabase
    {
        public static List<TodoTask> Taskuri = new List<TodoTask>
        {
            new TodoTask { Titlu = "Pregătit prezentare laborator",    Descriere = "Slide-uri pentru seminarul de WinForms",           Prioritate = Prioritate.Inalta,  DataCreare = new DateTime(2024, 10, 1),  Efectuat = true  },
            new TodoTask { Titlu = "Corectat teme studenți",           Descriere = "Tema 3 — delegați și evenimente",                 Prioritate = Prioritate.Inalta,  DataCreare = new DateTime(2024, 10, 3),  Efectuat = true  },
            new TodoTask { Titlu = "Actualizat GitBook cu lab05",      Descriere = "Adăugat paginile despre repository pattern",      Prioritate = Prioritate.Medie,   DataCreare = new DateTime(2024, 10, 5),  Efectuat = false },
            new TodoTask { Titlu = "Trimis feedback teze",             Descriere = "Feedback individual pentru studenții din seria B", Prioritate = Prioritate.Inalta,  DataCreare = new DateTime(2024, 10, 7),  Efectuat = false },
            new TodoTask { Titlu = "Instalat SQL Server pe lab",       Descriere = "Pregătit mediul pentru seminarul ADO.NET",        Prioritate = Prioritate.Medie,   DataCreare = new DateTime(2024, 10, 8),  Efectuat = true  },
            new TodoTask { Titlu = "Scris exercițiu lab ADO.NET",      Descriere = "Aplicație cu CRUD complet pe baza de date",      Prioritate = Prioritate.Medie,   DataCreare = new DateTime(2024, 10, 10), Efectuat = false },
            new TodoTask { Titlu = "Rezervat sala pentru prezentări",  Descriere = "Sala C205 pentru sesiunea de prezentări proiecte",Prioritate = Prioritate.Scazuta, DataCreare = new DateTime(2024, 10, 11), Efectuat = false },
            new TodoTask { Titlu = "Publicat subiecte examen parțial", Descriere = "Subiecte model pe platforma cursului",           Prioritate = Prioritate.Inalta,  DataCreare = new DateTime(2024, 10, 12), Efectuat = false },
            new TodoTask { Titlu = "Actualizat CV pentru conferință",  Descriere = "Adăugat publicațiile din 2024",                  Prioritate = Prioritate.Scazuta, DataCreare = new DateTime(2024, 10, 13), Efectuat = true  },
            new TodoTask { Titlu = "Verificat proiecte de semestru",   Descriere = "Revizuit cerințele pentru proiectele finale",    Prioritate = Prioritate.Medie,   DataCreare = new DateTime(2024, 10, 14), Efectuat = false },
        };
    }
}
