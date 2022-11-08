using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateClassAccessories.Items.WarriorAccessories
{
    public class BloodyBerserkerGlove : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloody Berserker's Glove");
            Tooltip.SetDefault("Increases melee knockback\n"
                + "12% increased melee damage\n"
                + "12% increased melee speed\n"
                + "Enables auto swing for melee weapons\n"
                + "Increases the size of melee weapons\n"
                + "Enemies are more likely to target you");
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
            player.statDefense += 4;
            player.GetKnockback<MeleeDamageClass>() *= 2;
            player.GetDamage<MeleeDamageClass>() *= 1.12f;
            player.GetAttackSpeed<MeleeDamageClass>() *= 1.12f;
            // enable auto swing of melee weapons
            player.itemWidth *= (int)1.10f;
            player.aggro += 400;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.BerserkerGlove, 1);
            recipe.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}