using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ComboAccessories.Content.Items.SummonerAccessories
{
    public class PygmyPapyrus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pygmy Papyrus");
            Tooltip.SetDefault("Increases you max number of minions by 3\n"
                + "Increases your summon damage by 15% and the knockback of your minions");
        }

        public override void SetDefaults()
        {
            Item.width = 36;
            Item.height = 36;
            Item.value = 100000; // 10 gold
            Item.rare = ItemRarityID.Lime;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions += 3;
            player.GetDamage<SummonDamageClass>() *= 1.15f;
            player.GetKnockback<SummonDamageClass>() += 2;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.PapyrusScarab, 1);
            recipe.AddIngredient(ItemID.PygmyNecklace, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}