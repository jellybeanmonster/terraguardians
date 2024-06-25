﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace terraguardians.Buffs.GhostFoxHaunts
{
    public class MeatHaunt : BeeHaunt
    {
        public override LocalizedText DisplayName => Language.GetOrRegister("Mods.terraguardians.Buffs.BeeHaunt.DisplayName");
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Haunted");
            //Description.SetDefault("A Ghost Guardian haunts you.\nHaunt is lifted if you defeat what killed It.\nYou sees flashes of a horrible flesh creature pulling her into It's mouth.");
            Main.debuff[this.Type] = true;
            Main.persistentBuff[this.Type] = true; //true
            Main.buffNoTimeDisplay[this.Type] = true;
            Main.pvpBuff[this.Type] = Main.buffNoSave[this.Type] = false;
            Terraria.ID.BuffID.Sets.NurseCannotRemoveDebuff[this.Type] = true;
        }
    }
}
