/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ComboAccessories.Content.Items.SummonerAccessories
{
    public class ScarabEmblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scarab Emblem");
            Tooltip.SetDefault("tooltip");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 200000; // 20 gold, not final
            Item.rare = ItemRarityID.Lime; // not final
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.PapyrusScarab, 1);
            recipe.AddIngredient(ItemID.SummonerEmblem, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.NecromanticScroll, 1);
            recipe.AddIngredient(ModContent.ItemType<BeetleEmblem>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}*/
