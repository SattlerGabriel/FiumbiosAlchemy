using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Placeable
{
  public class BeginnerTransmutationRune : ModItem
  {
    public override void SetStaticDefaults()
    {
      Tooltip.SetDefault("Allows one to transmute basic metals.");
    }

    public override void SetDefaults()
    {
      Item.width = 52;
      Item.height = 52;
      Item.maxStack = 1;
      Item.rare = ItemRarityID.Orange;

      Item.useTurn = true;
      Item.autoReuse = true;
      Item.useAnimation = 15;
      Item.useTime = 10;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.consumable = true;

      Item.createTile = ModContent.TileType<Tiles.BeginnerTransmutationRuneTile>();
    }

    public override void AddRecipes()
    {
      Recipe recipe = CreateRecipe()
        .AddIngredient(ItemID.HellstoneBar, 15)
        .AddIngredient(ItemID.Diamond, 15)
        .AddTile(TileID.DemonAltar)
        .Register();
    }
  }
}