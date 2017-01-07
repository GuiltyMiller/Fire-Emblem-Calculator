﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {InitializeComponent();}

        #region PlayerStatConversion
        private Stats GetPlayerVariables()
        {   Stats player = new Stats();
            player.Str = System.Convert.ToInt32(STR.Value);
            player.Mag = System.Convert.ToInt32(MAG.Value);
            player.Skl = System.Convert.ToInt32(SKL.Value);
            player.Spd = System.Convert.ToInt32(SPD.Value);
            player.Lck = System.Convert.ToInt32(LCK.Value);
            player.Def = System.Convert.ToInt32(DEF.Value);
            player.Res = System.Convert.ToInt32(RES.Value);
            player.Con = System.Convert.ToInt32(CON.Value);
            player.CMagic = MagCheck.Checked;
            player.WeaponTriangle = WeaponAdvantage.Checked;
            player.SRankBonus = SRank.Checked;
            return player;  }
        #endregion

        #region EnemyStatConversion
        private Stats GetEnemyVariables()
        {   Stats enemy = new Stats();
            enemy.Str = System.Convert.ToInt32(eSTR.Value);
            enemy.Mag = System.Convert.ToInt32(eMAG.Value);
            enemy.Skl = System.Convert.ToInt32(eSKL.Value);
            enemy.Spd = System.Convert.ToInt32(eSPD.Value);
            enemy.Lck = System.Convert.ToInt32(eLCK.Value);
            enemy.Def = System.Convert.ToInt32(eDEF.Value);
            enemy.Res = System.Convert.ToInt32(eRES.Value);
            enemy.Con = System.Convert.ToInt32(eCON.Value);
            enemy.CMagic = eMagCheck.Checked;
            enemy.WeaponTriangle = WeaponAdvantage.Checked;
            enemy.SRankBonus = SRank.Checked;
            return enemy;   }
        #endregion

        #region PlayerWeaponConversion
        private Weapons GetPlayerWeaponVariables()
        {   Weapons playerweapon = new Weapons();
            playerweapon.WMT = System.Convert.ToInt32(WeaponMT.Value);
            playerweapon.WHIT = System.Convert.ToInt32(WeaponHit.Value);
            playerweapon.WCRIT = System.Convert.ToInt32(WeaponCrit.Value);
            playerweapon.WWEIGHT = System.Convert.ToInt32(WeaponWeight.Value);
            playerweapon.EFFECTIVEMTBONUS = System.Convert.ToInt32(eWeaponMTBonus.Value);
            playerweapon.EFFECTIVE = WeaponAdvantage.Checked;
            return playerweapon;    }
        #endregion

        #region EnemyWeaponConversion
        private Weapons GetEnemyWeaponVariables()
        {   Weapons enemyweapon = new Weapons();
            enemyweapon.WMT = System.Convert.ToInt32(eWeaponMT.Value);
            enemyweapon.WHIT = System.Convert.ToInt32(eWeaponHit.Value);
            enemyweapon.WCRIT = System.Convert.ToInt32(eWeaponCrit.Value);
            enemyweapon.WWEIGHT = System.Convert.ToInt32(eWeaponWeight.Value);
            enemyweapon.EFFECTIVEMTBONUS = System.Convert.ToInt32(eWeaponMTBonus.Value);
            enemyweapon.EFFECTIVE = eWeaponAdvantage.Checked;
            return enemyweapon; }
        #endregion

        #region Player Support Conversion
        private Support GetPlayerSupportVariables()
        {   Support playersupport = new Support();
            playersupport.SupportBonusHit = System.Convert.ToInt32(SupportHit.Value);
            playersupport.SupportBonusMT = System.Convert.ToInt32(SupportMT.Value);
            playersupport.SupportBonusDEF = System.Convert.ToInt32(SupportDef.Value);
            playersupport.SupportBonusRES = System.Convert.ToInt32(SupportRes.Value);
            playersupport.SupportBonusEvade = System.Convert.ToInt32(SupportEvade.Value);
            playersupport.SupportBonusCrit = System.Convert.ToInt32(SupportCrit.Value);
            playersupport.SupportBonusCritEvade = System.Convert.ToInt32(SupportCritEvade.Value);
            playersupport.ClassCritical = System.Convert.ToInt32(ClassCriticalBox.Value);
            return playersupport;   }
        #endregion

        #region Enemy Support Conversion
        private Support GetEnemySupportVariables()
        {   Support enemysupport = new Support();
            enemysupport.SupportBonusHit = System.Convert.ToInt32(eSupportHit.Value);
            enemysupport.SupportBonusMT = System.Convert.ToInt32(eSupportMT.Value);
            enemysupport.SupportBonusDEF = System.Convert.ToInt32(eSupportDef.Value);
            enemysupport.SupportBonusRES = System.Convert.ToInt32(eSupportRes.Value);
            enemysupport.SupportBonusEvade = System.Convert.ToInt32(eSupportEvade.Value);
            enemysupport.SupportBonusCrit = System.Convert.ToInt32(eSupportCrit.Value);
            enemysupport.SupportBonusCritEvade = System.Convert.ToInt32(eSupportCritEvade.Value);
            enemysupport.ClassCritical = System.Convert.ToInt32(eClassCriticalBox.Value);
            return enemysupport;    }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            GetPlayerVariables();
            GetEnemyVariables();
            GetPlayerWeaponVariables();
            GetEnemyWeaponVariables();
            GetPlayerSupportVariables();
            GetEnemySupportVariables();
        }
    }
}