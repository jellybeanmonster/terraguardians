using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace terraguardians.Items.Weapons.SallyStench
{
    public class LaserPistol : GuardianItemPrefab
    {
        public override void SetDefaults()
        {
			Item.autoReuse = true;
			Item.useStyle = 5;
            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.mana = 2;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.knockBack = 3f;
			Item.noMelee = true;
			Item.UseSound = SoundID.Item157;
			Item.shootSpeed = 10f;
            Item.crit = 4;
            Item.scale *= 0.8f;
            Item.shoot = ModContent.ProjectileType<Projectiles.LaserPistolShot>();
        }

        public override bool CanUseItem(Player player)
        {
            if(!(player is TerraGuardian) || !(player as TerraGuardian).GetCompanionID.IsSameID(CompanionDB.CaptainStench))
            {
                switch(itemType)
                {
                    case ItemType.Heavy:
                        Main.NewText("This item is too heavy for me.");
                        break;
                    case ItemType.Shield:
                    case ItemType.OffHand:
                        Main.NewText("I can't use this.");
                        break;
                }
            }
            return false;
        }
    }
}