using System.Collections.Generic;
using FiumbiosAlchemy.Content.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Materials
{
    public class AdvancedTierScrapOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alchemical Scrap");
            Tooltip.SetDefault("Advanced Component" +
                               "\nCan be transmuted into any late hardmode metal ore");
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 32;
            Item.maxStack = 999;
            Item.value = 600 * 5;
            Item.rare = ItemRarityID.Pink;
            Item.material = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[2].OverrideColor = Color.DimGray;
        }

        public override void AddRecipes()
        {
            Recipe recipe;

            recipe = CreateRecipe()
                .AddIngredient(ItemID.ChlorophyteOre)
                .AddTile(ModContent.TileType<AdvancedTransmutationRuneTile>())
                .Register();
            recipe = CreateRecipe(5)
                .AddIngredient(ItemID.ChlorophyteBar)
                .AddTile(ModContent.TileType<AdvancedTransmutationRuneTile>())
                .Register();


            recipe = CreateRecipe(3)
                .AddIngredient(ItemID.LunarOre)
                .AddTile(ModContent.TileType<AdvancedTransmutationRuneTile>())
                .Register();
            recipe = CreateRecipe(12)
                .AddIngredient(ItemID.LunarBar)
                .AddTile(ModContent.TileType<AdvancedTransmutationRuneTile>())
                .Register();
        }
    }
}