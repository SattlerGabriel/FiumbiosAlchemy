using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Placeable
{
  public class AdvancedTransmutationRune : ModItem
  {
    public override void SetStaticDefaults()
    {
      Tooltip.SetDefault("Allows one to transmute otherwordly metals.");
    }

    public override void SetDefaults()
    {
      Item.width = 52;
      Item.height = 52;
      Item.maxStack = 1;
      Item.rare = ItemRarityID.Red;

      Item.useTurn = true;
      Item.autoReuse = true;
      Item.useAnimation = 15;
      Item.useTime = 10;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.consumable = true;

      Item.createTile = ModContent.TileType<Tiles.AdvancedTransmutationRuneTile>();
    }

    public override void AddRecipes()
    {
      Recipe recipe = CreateRecipe()
        .AddIngredient(ModContent.ItemType<IntermediateTransmutationRune>())
        .AddIngredient(ItemID.LunarBar, 10)
        .AddIngredient(ItemID.FragmentNebula, 15)
        .AddIngredient(ItemID.FragmentSolar, 15)
        .AddIngredient(ItemID.FragmentStardust, 15)
        .AddIngredient(ItemID.FragmentVortex, 15)
        .Register();
    }
  }
}