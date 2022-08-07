using FiumbiosAlchemy.Content.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Placeable
{
  public class DistilleryItem : ModItem
  {
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Distillery");
      Tooltip.SetDefault("Allows you to make saturated potions");
    }

    public override void SetDefaults()
    {
      Item.width = 48;
      Item.height = 48;
      Item.maxStack = 999;
      Item.rare = ItemRarityID.LightRed;

      Item.useTurn = true;
      Item.autoReuse = true;
      Item.useAnimation = 15;
      Item.useTime = 10;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.consumable = true;

      Item.createTile = ModContent.TileType<DistilleryTile>();
    }

    public override void AddRecipes()
    {
      Recipe recipe = CreateRecipe()
        .AddIngredient(ItemID.Glass, 10)
        .AddIngredient(ItemID.PixieDust, 5)
        .AddRecipeGroup(RecipeGroupID.IronBar, 3)
        .AddTile(TileID.Anvils)
        .Register();
    }
  }
}