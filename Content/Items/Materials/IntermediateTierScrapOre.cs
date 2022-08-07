using System.Collections.Generic;
using FiumbiosAlchemy.Content.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Materials
{
  public class IntermediateTierScrapOre : ModItem
  {
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Alchemical Scrap");
      Tooltip.SetDefault("Intermediate Component" +
                         "\nCan be transmuted into any basic hardmode metal ore");
    }

    public override void SetDefaults()
    {
      Item.width = 28;
      Item.height = 42;
      Item.maxStack = 999;
      Item.value = 600 * 5;
      Item.rare = ItemRarityID.Pink;
    }

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
      tooltips[2].OverrideColor = Color.DimGray;
    }

    public override void AddRecipes()
    {
      var amount = 1;
      var barMult = 3;
      Recipe recipe;

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.CobaltOre)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.CobaltBar)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.PalladiumOre)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.PalladiumBar)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();

      amount = 2;
      barMult = 4;
      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.MythrilOre)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.MythrilBar)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.OrichalcumOre)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.OrichalcumBar)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();

      amount = 4;
      barMult = 4;
      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.AdamantiteOre)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.AdamantiteBar)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.TitaniumOre)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.TitaniumBar)
        .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
        .Register();
    }
  }
}