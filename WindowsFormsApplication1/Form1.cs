using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool Form2Open = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!Form2Open)
            {
                Form2 NewWindow = new Form2(this);
                Form2Open = true;
                NewWindow.Show();
            }
        }

        public class CalculatorObjectsVariables
        {
            public int Level;
            public int Hp;
            public int Str;
            public int Mag;
            public int Skl;
            public int Spd;
            public int Lck;
            public int Def;
            public int Res;
            public int Con;
            public int Exp;

            public CalculatorObjectsVariables()
            {
                Level = 1;
                Hp = 0;
                Str = 0;
                Mag = 0;
                Skl = 0;
                Spd = 0;
                Lck = 0;
                Def = 0;
                Res = 0;
                Con = 0;
                Exp = 0;
            }

        }

        public class Calculations
        {


        }


        public class WeaponVariables
        {
            private string Name;
            private int ID;
            private static int Durability;
            private int MT;
            private int Hit;
            private int Crit;
            private int Weight;
            private string WeaponType;
            private bool EffectiveArmor;
            private bool EffectiveMount;
            private bool EffectiveDragon;
            private bool EffectiveBeast;
            private bool EffectiveSword;
            private bool EffectiveAxe;
            private bool EffectiveLance;
            private bool Effective;
            private int EffectiveMTBonus;
            public int EffectiveMTBonus2;

            public WeaponVariables()
            {
                Name = "Unknown";
                ID = 10000;
                Durability = 0;
                MT = 0;
                Hit = 0;
                Crit = 0;
                Weight = 0;
                WeaponType = "Sword";
                EffectiveArmor = false;
                EffectiveMount = false;
                EffectiveDragon = false;
                EffectiveBeast = false;
                EffectiveSword = false;
                EffectiveAxe = false;
                EffectiveLance = false;
                Effective = false;
                EffectiveMTBonus = 0;
                EffectiveMTBonus2 = 0;
            }
        }

        public class PersonalWeapon
        {
            public string Name;
            private int ID;
            private int Durability;
        }

    }
}