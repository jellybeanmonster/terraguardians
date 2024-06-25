using Terraria;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;

namespace terraguardians.Companions.Wrath.SubAttacks
{
    internal class WrathBulletReflectingBellyAttack : SubAttackBase
    {
        public override string Name => "Bullet Reflecting Belly";
        public override string Description => "Wrath reflects bullets fired towards them by using their belly.";
        public override bool AllowItemUsage => false;
        public override float Cooldown => 35;

        /*public override bool AutoUseCondition(Companion User, SubAttackData Data)
        {
            if (User.TargettingSomething && User.HasBeenMet) //Need to find out when they were hit by projectile.
            {
                Vector2 Distances = User.Center - User.Target.Center;
                if (Main.rand.NextFloat() < 0.4f && Math.Abs(Distances.X) < (User.width + User.Target.width) * .5f + 180 && Math.Abs(Distances.Y) < User.Target.height * .5f + 80)
                {
                    return true;
                }
            }
            return base.AutoUseCondition(User, Data);
        }*/

        public override void Update(Companion User, SubAttackData Data)
        {
            User.MoveLeft = User.MoveRight = User.ControlJump = User.MoveDown = false;
            if (Data.GetTime == 15)
            {
                if(User.Target != null)
                {
                    User.direction = (User.Center.X < User.Target.Center.X ? 1 : -1);
                }
            }
            if (Data.GetTime == 30)
            {
                User.SaySomething("*SHOOT ME NOW! IM BUILT FOR THIS!!!*");
            }
            if (Data.GetTime >= 240)
            {
                Data.EndUse();
            }
        }

        public override void UpdateAnimation(Companion User, SubAttackData Data)
        {
            bool CloudForm = (User.Data as PigGuardianFragmentPiece.PigGuardianFragmentData).IsCloudForm;
            if (Data.GetTime < 30)
            {
                User.ArmFramesID[0] = User.ArmFramesID[1] = 21;
                if (CloudForm) User.BodyFrameID = 20;
            }
            else
            {
                User.ArmFramesID[0] = User.ArmFramesID[1] = 22;
                if (CloudForm) User.BodyFrameID = 19;
            }
        }

        public override void UpdateStatus(Companion User, SubAttackData Data)
        {
            if (Data.GetTime >= 30)
                User.statDefense *= 2;
        }

        public override bool ImmuneTo(Companion User, SubAttackData Data, PlayerDeathReason damageSource, int cooldownCounter, bool dodgeable)
        {
            if (Data.GetTime >= 30 && damageSource.SourceProjectileLocalIndex > -1)
            {
                Projectile proj = Main.projectile[damageSource.SourceProjectileLocalIndex];
                if (proj.velocity.X != 0 && proj.velocity.Y != 0 && !IsBlacklistedProjectile(proj.type))
                {
                    proj.penetrate++;
                    proj.velocity.X *= -1;
                    proj.velocity.Y *= -1;
                    if (proj.friendly)
                    {
                        proj.GetGlobalProjectile<ProjMod>().ProjectileOwnerCompanion = User;
                    }
                    else
                    {
                        proj.friendly = !proj.friendly;
                        proj.hostile = !proj.hostile;
                    }
                }
                return true;
            }
            return base.ImmuneTo(User, Data, damageSource, cooldownCounter, dodgeable);
        }

        private bool IsBlacklistedProjectile(int Type)
        {
            switch (Type)
            {
                case ProjectileID.PhantasmalDeathray:
                case ProjectileID.CultistBossLightningOrb:
                case ProjectileID.CultistBossLightningOrbArc:
                case ProjectileID.Sharknado:
                case ProjectileID.HallowBossDeathAurora:
                case ProjectileID.HallowBossLastingRainbow:
                    return true;
            }
            return false;
        }
    }
}
