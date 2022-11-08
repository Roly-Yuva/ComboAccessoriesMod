using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateClassAccessories.Items.WarriorAccessories
{
    public class FieryBerserkerGlove : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fiery Berserker's Glove");
            Tooltip.SetDefault("Melee attacks inflict fire damage\n"
                + "Increases melee knockback\n"
                + "12% increased melee speed\n"
                + "Enables auto swing for melee weapons\n"
                + "Increases the size of melee weapons\n"
                + "Enemies are more likely to target you");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 150000; // 15 gold
            Item.rare = ItemRarityID.Pink;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.magmaStone = true;
            player.statDefense += 4;
            player.GetKnockback<MeleeDamageClass>() *= 2;
            player.GetAttackSpeed<MeleeDamageClass>() *= 1.12f;
            // enable auto swing of melee weapons
            player.itemWidth *= (int)1.10f;
            player.aggro += 400;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.BerserkerGlove, 1);
            recipe.AddIngredient(ItemID.MagmaStone, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}