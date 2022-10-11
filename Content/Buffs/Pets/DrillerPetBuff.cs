using Terraria;
using Terraria.ModLoader;
using ArcanumMod.Content.Projectiles.Pets;
using ArcanumMod.Common.Players;

namespace ArcanumMod.Content.Buffs.Pets {
    public class DrillerPetBuff : ModBuff {
        public override string Texture => ArcanumMod.AssetPath + "Textures/Buffs/Pets/DrillerPetBuff";

        public override void SetStaticDefaults() {
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex) {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<ArcPlayer>().drillerPet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<DrillerPet>()] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
                Projectile.NewProjectile(player.GetSource_Buff(buffIndex), player.position.X + (player.width / 2),
                    player.position.Y + (player.height / 2), 0f, 0f, ModContent.ProjectileType<DrillerPet>(), 0, 0f, player.whoAmI, 0f, 0f);
        }
    }
}