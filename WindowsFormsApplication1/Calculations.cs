using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Calculations
    {

        //If S Rank Bonus is true, add to hit/crit.
        //If (player.WeaponTriangle ? 15 : 0) is true, add 15 to Accuracy and 1 to damage.
        //If CMagic is true, change the calculations so it uses MAG instead of STR.
        //Return Value to Mainform and replace read-only textboxes' text to the result. (Ally/Enemy Damage/Hit/Crit)

        public CalculationsResults getCalculationResults(Stats player, Stats enemy, Weapons wPlayer, Weapons wEnemy, Support sPlayer, Support sEnemy)
        {
            CalculationsResults result = new CalculationsResults();

            #region Ally Hit Calcuations
            int HitTotal = wPlayer.WHIT + player.Skl * 2 + player.Lck / 2 + sPlayer.SupportBonusHit + (player.SRankBonus ? 5 : 0);
            #endregion
            #region Enemy Hit Calculations
            int eHitTotal = wEnemy.WHIT + enemy.Skl * 2 + enemy.Lck / 2 + sEnemy.SupportBonusHit + (enemy.SRankBonus ? 5 : 0);
            #endregion

            #region Evasion
            //Ally Attack Speed
            int ATKSPD;
            int ATKSPD2 = wPlayer.WWEIGHT - player.Con;
            if (player.Con >= wPlayer.WWEIGHT){ATKSPD = player.Spd;}else{ATKSPD = player.Spd - ATKSPD2;}
            //Enemy Attack Speed
            int eATKSPD;
            int eATKSPD2 = wEnemy.WWEIGHT - enemy.Con;
            if (enemy.Con >= wEnemy.WWEIGHT){eATKSPD = enemy.Spd;}else{eATKSPD = enemy.Spd - eATKSPD2;}

            int EvasionTotal = ATKSPD * 2 + player.Lck + sPlayer.SupportBonusEvade;
            int eEvasionTotal = eATKSPD * 2 + enemy.Lck + sEnemy.SupportBonusEvade;
            #endregion

            #region Accuracy
            result.Accuracy = HitTotal - eEvasionTotal + sPlayer.SupportBonusHit + (player.WeaponTriangle ? 15 : 0) - (enemy.WeaponTriangle ? 15 : 0);
            result.EAccuracy = eHitTotal - EvasionTotal + sEnemy.SupportBonusHit + (enemy.WeaponTriangle ? 15 : 0) - (player.WeaponTriangle ? 15 : 0);

            #endregion




            #region Damage
            int DamageA = (player.CMagic ? player.Mag : player.Str) + (wPlayer.WMT + (player.WeaponTriangle ? 1 : 0) - (enemy.WeaponTriangle ? 1 : 0)) * (wPlayer.EFFECTIVE ? 3 : 1) + wPlayer.EFFECTIVEMTBONUS + sPlayer.SupportBonusMT;
            int eDamageA = (enemy.CMagic ? enemy.Mag : enemy.Str) + (wEnemy.WMT + (enemy.WeaponTriangle ? 1 : 0) - (player.WeaponTriangle ? 1 : 0)) * (wEnemy.EFFECTIVE ? 3 : 1) + wEnemy.EFFECTIVEMTBONUS + sEnemy.SupportBonusMT;
            #endregion





            #region Defense
            int DefenseT = player.Def + sPlayer.SupportBonusDEF;
            int eDefenseT = enemy.Def + sEnemy.SupportBonusDEF;
            int ResistanceT = player.Res + sPlayer.SupportBonusDEF;
            int eResistanceT = enemy.Res + sEnemy.SupportBonusDEF;
            #endregion






            #region Damage Calculation
            result.TotalDamage = DamageA - (player.CMagic ? eResistanceT : eDefenseT);
            result.ETotalDamage = eDamageA - (enemy.CMagic ? ResistanceT : DefenseT);
            #endregion





            #region Critical Calculations
            int CritA = wPlayer.WCRIT + player.Skl / 2 + sPlayer.SupportBonusCrit + sPlayer.ClassCritical + (player.SRankBonus ? 5 : 0);
            int eCritA = wEnemy.WCRIT + enemy.Skl / 2 + sEnemy.SupportBonusCrit + sEnemy.ClassCritical + (enemy.SRankBonus ? 5 : 0);
            int CritEvade = player.Lck + sPlayer.SupportBonusCritEvade;
            int eCritEvade = enemy.Lck + sEnemy.SupportBonusCritEvade;
            result.CritTotal = CritA - eCritEvade;
            result.ECritTotal = eCritA - CritEvade;

            #endregion





            #region Double Attack Calculation
            result.DoubleAttack = player.Spd - enemy.Spd;
            result.EDoubleAttack = enemy.Spd - player.Spd;
            #endregion
            return result;
        }
    }
}

