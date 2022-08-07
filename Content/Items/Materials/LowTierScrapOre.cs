using System.Collections.Generic;
using FiumbiosAlchemy.Content.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Materials
{
  public class LowTierScrapOre : ModItem
  {
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Alchemical Scrap");
      Tooltip.SetDefault("Basic Component" +
                         "\nCan be transmuted into any pre-hardmode metal ore");
    }

    public override void SetDefaults()
    {
      Item.width = 28;
      Item.height = 48;
      Item.maxStack = 999;
      Item.value = 50 * 5;
      Item.rare = ItemRarityID.Orange;
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

      //Copper & Tin
      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.CopperOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.CopperBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.TinOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.TinBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      //Iron & Lead
      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.IronOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.IronBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.LeadOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.LeadBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      amount = 2;
      barMult = 4;
      //Silver & Tungsten
      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.SilverOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.SilverBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.TungstenOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.TungstenBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      amount = 3;
      barMult = 4;
      //Gold & Platinum
      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.GoldOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.GoldBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.PlatinumOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.PlatinumBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      amount = 5;
      barMult = 3;
      //Demonite & Crimtane
      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.DemoniteOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.DemoniteBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.CrimtaneOre)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.CrimtaneBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      amount = 4;
      barMult = 4;
      //Meteor & Hellstone
      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.Meteorite)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.MeteoriteBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();

      recipe = CreateRecipe(amount)
        .AddIngredient(ItemID.Hellstone)
        .AddIngredient(ItemID.Obsidian)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
      recipe = CreateRecipe(amount * barMult)
        .AddIngredient(ItemID.HellstoneBar)
        .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
        .Register();
    }
  }
}