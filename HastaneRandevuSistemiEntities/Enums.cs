using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemiEntities
{
    public class Enums
    {
        public int TheKey { get; set; }
        public string TheValue { get; set; }
    }
    public enum Branslar:Byte //byte vermemizin sebebi enumlara default numara vermeleri gerek
    {
        BransYok,
        Dahiliye,
        KBB,
        GozHastaliklari,
        Ortopedi,
        Kardiyoloji
    }
}
