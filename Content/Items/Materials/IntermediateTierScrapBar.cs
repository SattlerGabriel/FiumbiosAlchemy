using FiumbiosAlchemy.Content.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Materials
{
    public class IntermediateTierScrapBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Smoldering Ashes");
            Tooltip.SetDefault("Can still be converted into alchemical components");
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Quest;
        }

        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ModContent.ItemType<IntermediateTierScrapOre>(), 3)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapBar>())
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();
        }
    }
}