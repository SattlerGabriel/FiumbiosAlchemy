using FiumbiosAlchemy.Content.Buff;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Potions
{
  public class DilutedLifeforcePotion : ModItem
  {
    public override void SetStaticDefaults()
    {
      Tooltip.SetDefault("Increase max life by 10%");
    }

    public override void SetDefaults()
    {
      Item.width = 20;
      Item.height = 28;
      Item.maxStack = 9999;
      Item.value = 500;
      Item.rare = ItemRarityID.Blue;

      Item.consumable = true;
      Item.useStyle = 2;
      Item.buffType = ModContent.BuffType<LesserLifeforce>();
      Item.buffTime = (60 * 60) * 8;
      Item.UseSound = SoundID.Item3;
    }

    public override void AddRecipes()
    {
      Recipe recipe = CreateRecipe()
        .AddIngredient(ItemID.Shiverthorn)
        .AddIngredient(ItemID.Waterleaf)
        .AddIngredient(ItemID.Moonglow)
        .AddIngredient(ItemID.BottledWater)
        .AddTile(TileID.Bottles)
        .Register();

      recipe = CreateRecipe()
        .AddIngredient(ItemID.Shiverthorn)
        .AddIngredient(ItemID.Waterleaf)
        .AddIngredient(ItemID.Moonglow)
        .AddIngredient(ItemID.BottledWater)
        .AddTile(TileID.AlchemyTable)
        .AddConsumeItemCallback(Recipe.ConsumptionRules.Alchemy)
        .Register();
    }
  }
}