using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Placeable
{
  public class IntermediateTransmutationRune : ModItem
  {
    public override void SetStaticDefaults()
    {
      Tooltip.SetDefault("Allows one to transmute advanced metals.");
    }

    public override void SetDefaults()
    {
      Item.width = 52;
      Item.height = 52;
      Item.maxStack = 1;
      Item.rare = ItemRarityID.Pink;

      Item.useTurn = true;
      Item.autoReuse = true;
      Item.useAnimation = 15;
      Item.useTime = 10;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.consumable = true;

      Item.createTile = ModContent.TileType<Tiles.IntermediateTransmutationRuneTile>();
    }

    public override void AddRecipes()
    {
      Recipe recipe = CreateRecipe()
        .AddIngredient(ModContent.ItemType<BeginnerTransmutationRune>())
        .AddIngredient(ItemID.HallowedBar, 15)
        .AddIngredient(ItemID.SoulofNight, 10)
        .AddIngredient(ItemID.SoulofLight, 10)
        .AddTile(TileID.MythrilAnvil)
        .Register();
    }
  }
}