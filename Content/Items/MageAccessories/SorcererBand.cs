using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateClassAccessories.Items.MageAccessories
{
    public class SorcererBand : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sorcerer Band");
            Tooltip.SetDefault("12% increased magic damage\n"
                + "Increases maximum mana by 20\n"
                + "Increases mana regeneration rate");
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.value = 40000; // 4 gold
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage<MagicDamageClass>() *= 1.12f;
            player.statManaMax2 += 20;
            player.manaRegen += (int)Math.Round((player.statMana / player.statManaMax) + 2.875);
            player.manaRegenDelay /= 3;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SorcererEmblem, 1);
            recipe.AddIngredient(ItemID.ManaRegenerationBand, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}