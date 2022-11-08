using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateClassAccessories.Items.WarriorAccessories
{
    public class RagingInfernoGauntlet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Raging Inferno Gauntlet");
            Tooltip.SetDefault("tooltip here");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 100000; // 10 gold, not final, be big
            Item.rare = ItemRarityID.Lime; // not final, be rare
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
        }

        public override void AddRecipes()
        {
            Recipe recipe1 = CreateRecipe();
            recipe1.AddIngredient(ItemID.FireGauntlet, 1);
            recipe1.AddIngredient(ItemID.FleshKnuckles, 1);
            recipe1.AddTile(TileID.TinkerersWorkbench);
            recipe1.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ModContent.ItemType<BloodyBerserkerGlove>(), 1);
            recipe2.AddIngredient(ItemID.MagmaStone, 1);
            recipe2.AddTile(TileID.TinkerersWorkbench);
            recipe2.Register();

            Recipe recipe3 = CreateRecipe();
            recipe3.AddIngredient(ModContent.ItemType<FieryBerserkerGlove>(), 1);
            recipe3.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe3.AddTile(TileID.TinkerersWorkbench);
            recipe3.Register();
        }
    }
}