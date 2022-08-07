using FiumbiosAlchemy.Content.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Materials
{
    public class LowTierScrapBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cold Ashes");
            Tooltip.SetDefault("Can still be converted into alchemical components");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 32;
            Item.maxStack = 999;
            Item.rare = ItemRarityID.Quest;
        }

        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ModContent.ItemType<LowTierScrapOre>(), 3)
                .AddIngredient(ModContent.ItemType<LowTierScrapBar>())
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
        }
    }
}