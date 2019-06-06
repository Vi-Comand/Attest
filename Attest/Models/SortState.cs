using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attest.Models
{
    public enum SortState
    {
        NomZayavAsc,    // по имени по возрастанию
        NomZayavDesc,
        NameAsc,
        NameDesc,// по имени по убыванию
        DataPodachAsc,
        DataPodachDesc,
        MoAsc,
        MoDesc,
        //DataObnovAsc,
        //DataObnovDesc,
        StatusAsc,
        StatusDesc,
        SpecAsc,
        SpecDesc,
        BalAsc,
        BalDesc
    }
}
