using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Stats
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

        //Getters and Setters
        public int Str
        {get{return str;}set{str = value;}}

        public int Mag
        {get{return mag;}set{mag = value;}}

        public int Skl
        {get{return skl;}set{skl = value;}}

        public int Spd
        {get{return spd;}set{spd = value;}}

        public int Lck
        {get{return lck;}set{lck = value;}}

        public int Def
        {get{return def;}set{def = value;}}

        public int Res
        {get{return res;}set{res = value;}}

        public int Con
        {get{return con;}set{con = value;}}

        public bool WeaponTriangle
        {get{return weaponTriangle;}set{weaponTriangle = value;}}

        public bool CMagic
        {get{return cMagic;}set{cMagic = value;}}

        public bool SRankBonus
        {get{return sRankBonus;}set{sRankBonus = value;}}

        public int WeaponTriangleMT
        {get{return weaponTriangleMT;}set{weaponTriangleMT = value;}}
    }
}
