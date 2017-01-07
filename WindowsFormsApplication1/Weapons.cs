using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Weapons
    {
        private int wMT;
        private int wHit;
        private int wCrit;
        private int wWeight;
        private bool effective;
        private int effectiveMTBonus;

        //Getters and Setters
        public int WMT
        {get{return wMT;}set{wMT = value;}}
        public int WHIT
        {get{return wHit;}set{wHit = value;}}

        public int WCRIT
        {get{return wCrit;}set{wCrit = value;}}

        public int WWEIGHT
        {get{return wWeight;}set{wWeight = value;}}

        public bool EFFECTIVE
        {get{return effective;}set{effective = value;}}

        public int EFFECTIVEMTBONUS
        {get{return effectiveMTBonus;}set{effectiveMTBonus = value;}}
    }


}
