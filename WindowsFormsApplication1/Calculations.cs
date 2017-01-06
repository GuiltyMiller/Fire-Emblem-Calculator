using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Calculations
    {
        /*



            #region Ally Hit Calcuations
            int HitTotal = wHit + Skl * 2 + Lck / 2 + SupportBonusHit + SRankBonus;
            #endregion
            #region Enemy Hit Calculations
            int eHitTotal = ewHit + eSkl * 2 + eLck / 2 + eSupportBonusHit + eSRankBonus;
            #endregion





            #region Evasion
            //Ally Attack Speed
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
            //Enemy Attack Speed
            int eATKSPD;
            int eATKSPD2 = ewWeight - eCon;
            if (Con >= ewWeight)
            {
                eATKSPD = eSpd;
            }
            else
            {
                eATKSPD = eSpd - eATKSPD2;
            }

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
                DamageA = Mag + wMT + WeaponTriangleMT * Effective + EffectiveMTBonus + SupportBonusMT;
            }
            else
            {
                DamageA = Str + wMT + WeaponTriangleMT * Effective + EffectiveMTBonus + SupportBonusMT;
            }
            if (ceMagic == 1)
            {
                eDamageA = eMag + ewMT + eWeaponTriangleMT * eEffective + eEffectiveMTBonus + eSupportBonusMT;
            }
            else
            {
                eDamageA = eStr + ewMT + eWeaponTriangleMT * eEffective + eEffectiveMTBonus + eSupportBonusMT;
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
                TotalDamage = DamageA - eResistanceT - eWeaponTriangleMT;
            }
            else
            {
                TotalDamage = DamageA - eDefenseT - eWeaponTriangleMT;
            }
            if (ceMagic == 1)
            {
                eTotalDamage = eDamageA - ResistanceT - WeaponTriangleMT;
            }
            else
            {
                eTotalDamage = eDamageA - DefenseT - WeaponTriangleMT;
            }
            string VarDam = TotalDamage.ToString();
            Damage.Text = VarDam;
            string eVarDam = eTotalDamage.ToString();
            eDamage.Text = eVarDam;
            #endregion





            #region Critical Calculations
            int CritA = wCrit + Skl / 2 + SupportBonusCrit + eClassCritical + SRankBonus;
            int eCritA = ewCrit + eSkl / 2 + eSupportBonusCrit + eClassCritical + eSRankBonus;
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
            #endregion */
    }
}
