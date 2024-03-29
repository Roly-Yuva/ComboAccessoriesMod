using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ComboAccessories.Content.Items.MageAccessories
{
    public class SorcererCuffs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sorcerer Cuffs");
            Tooltip.SetDefault("12% increased magic damage\n"
                + "Increases maximum mana by 20\n"
                + "Restores mana when damaged");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 50000; // 5 gold
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage<MagicDamageClass>() *= 1.12f;
            player.statManaMax2 += 20;
            player.magicCuffs = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<SorcererBand>(), 1);
            recipe.AddIngredient(ItemID.Shackle, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MagicCuffs, 1);
            recipe.AddIngredient(ItemID.SorcererEmblem, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}
