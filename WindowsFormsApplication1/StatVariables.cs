using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class StatVariables
    {
        private int str;
        private int mag;
        private int skl;
        private int spd;
        private int lck;
        private int def;
        private int res;
        private int con;
        private bool weaponTriangle = false;
        private bool cMagic = false;
        private bool sRankBonus = false;
        private int weaponTriangleMT = 0;
        private int supportBonusHit = 0;
        private int supportBonusMT = 0;
        private int supportBonusDEF = 0;
        private int supportBonusRES = 0;
        private int supportBonusEvade = 0;
        private int supportBonusCrit = 0;
        private int supportBonusCritEvade = 0;
        private int classCritical = 0;

        public int Str
        {
            get
            {
                return str;
            }

            set
            {
                str = value;
            }
        }

        public int Mag
        {
            get
            {
                return mag;
            }

            set
            {
                mag = value;
            }
        }

        public int Skl
        {
            get
            {
                return skl;
            }

            set
            {
                skl = value;
            }
        }

        public int Spd
        {
            get
            {
                return spd;
            }

            set
            {
                spd = value;
            }
        }

        public int Lck
        {
            get
            {
                return lck;
            }

            set
            {
                lck = value;
            }
        }

        public int Def
        {
            get
            {
                return def;
            }

            set
            {
                def = value;
            }
        }

        public int Res
        {
            get
            {
                return res;
            }

            set
            {
                res = value;
            }
        }

        public int Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        public bool WeaponTriangle
        {
            get
            {
                return weaponTriangle;
            }

            set
            {
                weaponTriangle = value;
            }
        }

        public bool CMagic
        {
            get
            {
                return cMagic;
            }

            set
            {
                cMagic = value;
            }
        }

        public bool SRankBonus
        {
            get
            {
                return sRankBonus;
            }

            set
            {
                sRankBonus = value;
            }
        }

        public int WeaponTriangleMT
        {
            get
            {
                return weaponTriangleMT;
            }

            set
            {
                weaponTriangleMT = value;
            }
        }

        public int SupportBonusHit
        {
            get
            {
                return supportBonusHit;
            }

            set
            {
                supportBonusHit = value;
            }
        }

        public int SupportBonusMT
        {
            get
            {
                return supportBonusMT;
            }

            set
            {
                supportBonusMT = value;
            }
        }

        public int SupportBonusDEF
        {
            get
            {
                return supportBonusDEF;
            }

            set
            {
                supportBonusDEF = value;
            }
        }

        public int SupportBonusRES
        {
            get
            {
                return supportBonusRES;
            }

            set
            {
                supportBonusRES = value;
            }
        }

        public int SupportBonusEvade
        {
            get
            {
                return supportBonusEvade;
            }

            set
            {
                supportBonusEvade = value;
            }
        }


        public int SupportBonusCrit
        {
            get
            {
                return supportBonusCrit;
            }

            set
            {
                supportBonusCrit = value;
            }
        }

        public int SupportBonusCritEvade
        {
            get
            {
                return supportBonusCritEvade;
            }

            set
            {
                supportBonusCritEvade = value;
            }
        }

        public int ClassCritical
        {
            get
            {
                return classCritical;
            }

            set
            {
                classCritical = value;
            }
        }
    }
}
