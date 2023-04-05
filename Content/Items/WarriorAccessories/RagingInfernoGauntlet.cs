/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ComboAccessories.Content.Items.WarriorAccessories
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
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FireGauntlet, 1);
            recipe.AddIngredient(ItemID.FleshKnuckles, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<BloodyBerserkerGlove>(), 1);
            recipe.AddIngredient(ItemID.MagmaStone, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<FieryBerserkerGlove>(), 1);
            recipe.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}*/
