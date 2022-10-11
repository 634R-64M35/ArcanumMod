using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using ArcanumMod.Content.Projectiles.Pets;
using ArcanumMod.Content.Buffs.Pets;

namespace ArcanumMod.Content.Items.Pets {
    public class DrillerPetRemote : ModItem {
        public override string Texture => ArcanumMod.AssetPath + "Textures/Items/Pets/DrillerPetRemote";

        public override void SetStaticDefaults() => SacrificeTotal = 1;

        public override void SetDefaults() {
            Item.CloneDefaults(ItemID.ZephyrFish);
            Item.UseSound = SoundID.Item112;
            Item.shoot = ModContent.ProjectileType<DrillerPet>();
            Item.value = Item.sellPrice(0, 1, 66, 9);
            Item.rare = ItemRarityID.Pink;
            Item.buffType = ModContent.BuffType<DrillerPetBuff>();
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame) {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
                player.AddBuff(Item.buffType, 3600, true);
        }
    }
}