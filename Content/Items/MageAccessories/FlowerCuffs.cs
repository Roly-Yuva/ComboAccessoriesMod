using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ComboAccessories.Content.Items.MageAccessories
{
    public class FlowerCuffs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flower Cuffs");
            Tooltip.SetDefault("Increases pickup range for mana stars\n"
                + "Restores mana when damaged\n"
                + "Increases maximum mana by 20\n"
                + "8% reduced mana usage\n"
                + "Automatically use mana potions when needed");
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 38;
            Item.value = 40000; // 4 gold
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.manaCost -= 0.08f;
            player.statManaMax2 += 20;
            player.manaFlower = true;
            player.manaMagnet = true;
            player.magicCuffs = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CelestialCuffs, 1);
            recipe.AddIngredient(ItemID.ManaFlower, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MagnetFlower, 1);
            recipe.AddIngredient(ItemID.MagicCuffs, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
