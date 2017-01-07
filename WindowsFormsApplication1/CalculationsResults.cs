using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CalculationsResults
    {
        private int accuracy;
        private int totalDamage;
        private int critTotal;
        private int doubleAttack; //If ally/enemy speed is 4 higher than the opposing speed, change 1x(double) label to 2x

        public int Accuracy
        { get { return accuracy } set { accuracy = value; } }

        public int TotalDamage
        { get { return totalDamage } set { totalDamage = value; } }

        public int CritTotal
        { get { return critTotal; } set { critTotal = value; } }

        public int DoubleAttack
        {get { return doubleAttack; }set { doubleAttack = value; }}


    }
}
