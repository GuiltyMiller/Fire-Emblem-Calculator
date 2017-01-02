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


        #region Weapons

        private int ewMT;
        private int ewHit;
        private int ewCrit;
        private int ewWeight;
        private int eEffective = 1;
        private int eEffectiveMTBonus;

        private int wMT;
        private int wHit;
        private int wCrit;
        private int wWeight;
        private int Effective = 1;
        private int EffectiveMTBonus;
        public void WeaponConversion()
        {
            wMT = System.Convert.ToInt32(WeaponMT.Value);
            wHit = System.Convert.ToInt32(WeaponHit.Value);
            wCrit = System.Convert.ToInt32(WeaponCrit.Value);
            wWeight = System.Convert.ToInt32(WeaponWeight.Value);
            EffectiveMTBonus = System.Convert.ToInt32(WeaponMTBonus.Value);

            ewMT = System.Convert.ToInt32(eWeaponMT.Value);
            ewHit = System.Convert.ToInt32(eWeaponHit.Value);
            ewCrit = System.Convert.ToInt32(eWeaponCrit.Value);
            ewWeight = System.Convert.ToInt32(eWeaponWeight.Value);
            eEffectiveMTBonus = System.Convert.ToInt32(eWeaponMTBonus.Value);
        }
        #endregion


        #region PlayerVariables
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
        public int WeaponTriangle = 0;
        public int cMagic = 0;
        public int SRankBonus = 0;
        public int WeaponTriangleMT = 0;
        public int SupportBonusHit = 0;
        public int SupportBonusMT = 0;
        public int SupportBonusDEF = 0;
        public int SupportBonusRES = 0;
        public int SupportBonusCrit = 0;
        public int SupportBonusCritEvade = 0;
        public int ClassCritical;
        public void CalculatorVariables()
        {
            Level = 1;
            Str = System.Convert.ToInt32(STR.Value);
            Mag = System.Convert.ToInt32(MAG.Value);
            Skl = System.Convert.ToInt32(SKL.Value);
            Spd = System.Convert.ToInt32(SPD.Value);
            Lck = System.Convert.ToInt32(LCK.Value);
            Def = System.Convert.ToInt32(DEF.Value);
            Res = System.Convert.ToInt32(RES.Value);
            Con = System.Convert.ToInt32(CON.Value);
        }
        #endregion


        #region EnemyVariables
        public int eHp;
        public int eStr;
        public int eMag;
        public int eSkl;
        public int eSpd;
        public int eLck;
        public int eDef;
        public int eRes;
        public int eCon;
        public int eWeaponTriangle = 0;
        public int ceMagic = 0;
        public int eSRankBonus = 0;
        public int eWeaponTriangleMT;
        public int eSupportBonusHit;
        public int eSupportBonusMT;
        public int eSupportBonusDEF;
        public int eSupportBonusRES;
        public int eSupportBonusCrit;
        public int eSupportBonusCritEvade;
        public int eClassCritical;
        public void EnemyCalculatorVariables()
        {
            eStr = System.Convert.ToInt32(eSTR.Value);
            eMag = System.Convert.ToInt32(eMAG.Value);
            eSkl = System.Convert.ToInt32(eSKL.Value);
            eSpd = System.Convert.ToInt32(eSPD.Value);
            eLck = System.Convert.ToInt32(eLCK.Value);
            eDef = System.Convert.ToInt32(eDEF.Value);
            eRes = System.Convert.ToInt32(eRES.Value);
            eCon = System.Convert.ToInt32(eCON.Value);
        }
        public void SupportVariables()
        {
            SupportBonusHit = System.Convert.ToInt32(SupportHit.Value);
            SupportBonusMT = System.Convert.ToInt32(SupportMT.Value);
            SupportBonusDEF = System.Convert.ToInt32(SupportDef.Value);
            SupportBonusRES = System.Convert.ToInt32(SupportRes.Value);
            SupportBonusCrit = System.Convert.ToInt32(SupportCrit.Value);
            SupportBonusCritEvade = System.Convert.ToInt32(SupportCritEvade.Value);
            ClassCritical = System.Convert.ToInt32(ClassCriticalBox.Value);
            eSupportBonusHit = System.Convert.ToInt32(eSupportHit.Value);
            eSupportBonusMT = System.Convert.ToInt32(eSupportMT.Value);
            eSupportBonusDEF = System.Convert.ToInt32(eSupportDef.Value);
            eSupportBonusRES = System.Convert.ToInt32(eSupportRes.Value);
            eSupportBonusCrit = System.Convert.ToInt32(eSupportCrit.Value);
            eSupportBonusCritEvade = System.Convert.ToInt32(eSupportCritEvade.Value);
            eClassCritical = System.Convert.ToInt32(eClassCriticalBox.Value);
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            
            CalculatorVariables();
            EnemyCalculatorVariables();
            WeaponConversion();
            SupportVariables();
            #region Ally Hit Calcuations
            int ATKSPD;
            int ATKSPD2 = wWeight - Con;
            if (Con >= wWeight)
            {
                ATKSPD = Spd;
            }
            else
            {
                ATKSPD = Spd - ATKSPD2;
            }
            int HitTotal = (((wHit + Skl) * 2 + Lck) / 2) + SupportBonusHit + SRankBonus;
            #endregion


            #region Enemy Hit Calculations
            int eATKSPD;
            int eATKSPD2 = wWeight - eCon;
            if (Con >= wWeight)
            {
                eATKSPD = eSpd;
            }
            else
            {
                eATKSPD = eSpd - eATKSPD2;
            }
            int eHitTotal = (((ewHit + eSkl) * 2 + eLck) / 2) + eSupportBonusHit + eSRankBonus;

            #endregion


            #region Evasion
            int EvasionTotal = ATKSPD * 2 + Lck + SupportBonusHit;
            int eEvasionTotal = eATKSPD * 2 + eLck + eSupportBonusHit;
            #endregion


            #region Accuracy
            int Accuracy;
            int eAccuracy;
            Accuracy = HitTotal - eEvasionTotal + SupportBonusHit + WeaponTriangle - eWeaponTriangle;
            eAccuracy = eHitTotal - EvasionTotal + eSupportBonusHit + eWeaponTriangle - WeaponTriangle;
            string VarHit = "0";
            VarHit = Accuracy.ToString();
            Hit.Text = VarHit;
            string eVarHit = "0";
            eVarHit = eAccuracy.ToString();
            eHit.Text = eVarHit;
            #endregion

            #region Damage
            int DamageA;
            int eDamageA;
            if (cMagic == 1)
            {
                DamageA = Mag + (wMT + WeaponTriangleMT) * Effective + EffectiveMTBonus + SupportBonusMT;
            }
            else
            {
                DamageA = Str + (wMT + WeaponTriangleMT) * Effective + EffectiveMTBonus + SupportBonusMT;
            }
            if (ceMagic == 1)
            {
                eDamageA = eMag + (ewMT + eWeaponTriangleMT) * eEffective + eEffectiveMTBonus + eSupportBonusMT;
            }
            else
            {
                eDamageA = eStr + (ewMT + eWeaponTriangleMT) * eEffective + eEffectiveMTBonus + eSupportBonusMT;
            }
            #endregion

            #region Defense
            int DefenseT = Def + SupportBonusDEF;
            int eDefenseT = eDef + eSupportBonusDEF;
            int ResistanceT = Res + SupportBonusDEF;
            int eResistanceT = eRes + eSupportBonusDEF;
            #endregion

            #region Damage Calculation
            int TotalDamage;
            int eTotalDamage;
            if (cMagic == 1)
            {
                TotalDamage = DamageA - eResistanceT;
            }
            else
            {
                TotalDamage = DamageA - eDefenseT;
            }
            if (ceMagic == 1)
            {
                eTotalDamage = eDamageA - ResistanceT;
            }
            else
            {
                eTotalDamage = eDamageA - DefenseT;
            }
            string VarDam = TotalDamage.ToString();
            Damage.Text = VarDam;
            string eVarDam = eTotalDamage.ToString();
            eDamage.Text = eVarDam;
            #endregion

            #region Critical Calculations
            int CritA = (wCrit + (Skl / 2)) + SupportBonusCrit +  eClassCritical + SRankBonus;
            int eCritA = (ewCrit + (eSkl / 2)) + eSupportBonusCrit + eClassCritical + eSRankBonus;
            int CritEvade = Lck + SupportBonusCritEvade;
            int eCritEvade = eLck + eSupportBonusCritEvade;
            int CritTotal = CritA - eCritEvade;
            int eCritTotal = eCritA - CritEvade;
            string VarCrit = CritTotal.ToString();
            Crit.Text = VarCrit;
            string eVarCrit = eCritTotal.ToString();
            eCrit.Text = eVarCrit;
            #endregion

            #region Double Attack Calculation
            int DoubleAtk = Spd - eSpd;
            int eDoubleAtk = eSpd - Spd;
            if (DoubleAtk >= 4)
            {
                DoubleAttack.Text = "2x";
            }
            else
            {
                DoubleAttack.Text = "1x";
            }
            if (eDoubleAtk >= 4)
            {
                eDoubleAttack.Text = "2x";
            }
            else
            {
                eDoubleAttack.Text = "1x";
            }
            #endregion
        }

        public void WeaponAdvantage_CheckedChanged(object sender, EventArgs e)
        {
            if (WeaponTriangle == 0)
            {
                WeaponTriangleMT = 1;
                WeaponTriangle = 15;
            }
            else
            {
                WeaponTriangle = 0;
                WeaponTriangleMT = 0;
            }

        }

        private void eWeaponAdvantage_CheckedChanged(object sender, EventArgs e)
        {
            if (eWeaponTriangle == 0)
            {
                eWeaponTriangleMT = 1;
                eWeaponTriangle = 15;
            }
            else
            {
                eWeaponTriangle = 0;
                eWeaponTriangleMT = 0;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SRankBonus == 0)
            {
                SRankBonus = 5;
            }
            else
            {
                SRankBonus = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (eSRankBonus == 0)
            {
                eSRankBonus = 5;
            }
            else
            {
                eSRankBonus = 0;
            }
        }

        private void Effectiveness_CheckedChanged(object sender, EventArgs e)
        {
            if (Effective == 1)
            {
                Effective = 2;
            }
            else
            {
                Effective = 1;
            }
        }

        private void eEffectiveness_CheckedChanged(object sender, EventArgs e)
        {
            if (eEffective == 1)
            {
                eEffective = 2;
            }
            else
            {
                eEffective = 1;
            }
        }

        private void Magic_CheckedChanged(object sender, EventArgs e)
        {
            if (cMagic == 0)
            {
                cMagic = 1;
            }
            else
            {
                cMagic = 0;
            }

        }

        private void eMagic_CheckedChanged(object sender, EventArgs e)
        {
            if (ceMagic == 0)
            {
                ceMagic = 1;
            }
            else
            {
                ceMagic = 0;
            }

        }
    }
}