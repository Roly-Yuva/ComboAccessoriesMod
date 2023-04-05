using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ComboAccesories
{
    public class ModRecipes : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe putridScent = Recipe.Create(ItemID.PutridScent, 1);
            putridScent.AddIngredient(ItemID.FleshKnuckles, 1);
            putridScent.AddIngredient(ItemID.WrathPotion, 1);
            putridScent.AddCondition(Recipe.Condition.InGraveyardBiome);
            putridScent.Register();

            Recipe fleshKnuckles = Recipe.Create(ItemID.FleshKnuckles, 1);
            fleshKnuckles.AddIngredient(ItemID.PutridScent, 1);
            fleshKnuckles.AddIngredient(ItemID.RagePotion, 1);
            fleshKnuckles.AddCondition(Recipe.Condition.InGraveyardBiome);
            fleshKnuckles.Register();
        }
    }
}