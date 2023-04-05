using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ComboAccessories.Content.Items.MageAccessories
{
    public class MagesCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mage's Charm");
            Tooltip.SetDefault("Increases pickup range for mana stars\n"
                + "Restores mana when damaged\n"
                + "Increases maximum mana by 40\n"
                + "10% reduced mana usage\n"
                + "Automatically use mana potions when needed\n"
                + "15% increased magic damage\n"
                + "Increases mana regeneration rate");
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 40;
            Item.value = 100000; // 10 gold; subject to change
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.manaMagnet = true;
            player.magicCuffs = true;
            player.manaFlower = true;
            player.statManaMax2 += 40;
            player.manaCost -= 0.10f;
            player.GetDamage<MagicDamageClass>() *= 1.15f;
            player.manaRegen += (int)Math.Round((player.statMana / player.statManaMax) + 2.875);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<FlowerCuffs>(), 1);
            recipe.AddIngredient(ModContent.ItemType<SorcererBand>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ManaFlower, 1);
            recipe.AddIngredient(ItemID.MagicCuffs, 1);
            recipe.AddIngredient(ItemID.CelestialMagnet, 1);
            recipe.AddIngredient(ItemID.SorcererEmblem, 1);
            recipe.AddIngredient(ItemID.ManaRegenerationBand, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
