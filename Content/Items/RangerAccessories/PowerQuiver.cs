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
            Tooltip.SetDefault("Increases arrow damage by 15% and greatly increases arrow speed\n"
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
            Recipe recipe1 = CreateRecipe();
            recipe1.AddIngredient(ItemID.MoltenQuiver, 1);
            recipe1.AddIngredient(ItemID.PutridScent, 1);
            recipe1.AddTile(TileID.TinkerersWorkbench);
            recipe1.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.StalkersQuiver, 1);
            recipe2.AddIngredient(ItemID.MagmaStone, 1);
            recipe2.AddTile(TileID.TinkerersWorkbench);
            recipe2.Register();

            Recipe recipe3 = CreateRecipe();
            recipe3.AddIngredient(ItemID.MoltenQuiver, 1);
            recipe3.AddIngredient(ItemID.StalkersQuiver, 1);
            recipe3.AddTile(TileID.TinkerersWorkbench);
            recipe3.Register();
        }
    }
}