using FiumbiosAlchemy.Content.Buff;
using FiumbiosAlchemy.Content.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Potions
{
  public class ConcentratedSummoningPotion : ModItem
  {
    public override void SetStaticDefaults()
    {
      Tooltip.SetDefault("Increased your max number of minions by 2");
    }

    public override void SetDefaults()
    {
      Item.width = 36;
      Item.height = 48;
      Item.maxStack = 99;
      Item.value = 500 * 5;
      Item.rare = ItemRarityID.LightRed;

      Item.consumable = true;
      Item.useStyle = ItemUseStyleID.DrinkLiquid;
      Item.useAnimation = 17;
      Item.useTime = 17;
      Item.buffType = ModContent.BuffType<ConcentratedSummoning>();
      Item.buffTime = 60 * 60 * 5;
      Item.UseSound = SoundID.Item3;
    }

    public override void AddRecipes()
    {
      Recipe recipe = CreateRecipe()
        .AddIngredient(ItemID.RagePotion, 3)
        .AddTile(ModContent.TileType<DistilleryTile>())
        .Register();
    }
  }
}