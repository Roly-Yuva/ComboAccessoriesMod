using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateClassAccessories.Items.RangerAccessories
{
    public class PowerQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Power Quiver");
            Tooltip.SetDefault("Increases arrow damage by 10% and greatly increases arrow speed\n"
                + "20% chance not to consume arrows\n"
                + "Lights wooden arrows ablaze\n"
                + "Enemies are less likely to target you\n");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 200000; // 20 gold
            Item.rare = ItemRarityID.LightPurple;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.archery = true; // idk what this does
            player.magicQuiver = true;
            player.hasMoltenQuiver = true;
            player.aggro -= 400;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MoltenQuiver, 1);
            recipe.AddIngredient(ItemID.PutridScent, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.StalkersQuiver, 1);
            recipe.AddIngredient(ItemID.MagmaStone, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MoltenQuiver, 1);
            recipe.AddIngredient(ItemID.StalkersQuiver, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
