using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Support
    {
        private int supportBonusHit = 0;
        private int supportBonusMT = 0;
        private int supportBonusDEF = 0;
        private int supportBonusRES = 0;
        private int supportBonusEvade = 0;
        private int supportBonusCrit = 0;
        private int supportBonusCritEvade = 0;
        private int classCritical = 0;

        //Getters and Setters
        public int SupportBonusHit
        {get{return supportBonusHit;}set{supportBonusHit = value;}}

        public int SupportBonusMT
        {get{return supportBonusMT;}set{supportBonusMT = value;}}

        public int SupportBonusDEF
        {get{return supportBonusDEF;}set{supportBonusDEF = value;}}

        public int SupportBonusRES
        {get{return supportBonusRES;}set{supportBonusRES = value;}}

        public int SupportBonusEvade
        {get{return supportBonusEvade;}set{supportBonusEvade = value;}}

        public int SupportBonusCrit
        {get{return supportBonusCrit;}set{supportBonusCrit = value;}}

        public int SupportBonusCritEvade
        {get{return supportBonusCritEvade;}set{supportBonusCritEvade = value;}}

        public int ClassCritical
        {get{return classCritical;}set{classCritical = value;}}
    }
}
