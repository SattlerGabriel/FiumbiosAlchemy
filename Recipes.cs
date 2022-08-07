using FiumbiosAlchemy.Content.Items.Materials;
using FiumbiosAlchemy.Content.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace FiumbiosAlchemy
{
    public class Recipes : ModSystem
    {
        public override void AddRecipes()
        {
            var orePrice = 2;
            var barPrice = 3;

            #region Low Tier

            Recipe low;
            low = Recipe.Create(ItemID.CopperOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.CopperBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            low = Recipe.Create(ItemID.TinOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.TinBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            low = Recipe.Create(ItemID.IronOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.IronBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            low = Recipe.Create(ItemID.LeadOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.LeadBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            orePrice = 3;
            barPrice = 4;
            low = Recipe.Create(ItemID.SilverOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.SilverBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            low = Recipe.Create(ItemID.TungstenOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.TungstenBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            orePrice = 4;
            barPrice = 4;
            low = Recipe.Create(ItemID.GoldOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.GoldBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            low = Recipe.Create(ItemID.PlatinumOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.PlatinumBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            orePrice = 6;
            barPrice = 3;
            low = Recipe.Create(ItemID.DemoniteOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.DemoniteBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            low = Recipe.Create(ItemID.CrimtaneOre)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.CrimtaneBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            orePrice = 5;
            barPrice = 4;
            low = Recipe.Create(ItemID.Meteorite)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.MeteoriteBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            low = Recipe.Create(ItemID.Hellstone)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();
            low = Recipe.Create(ItemID.HellstoneBar)
                .AddIngredient(ModContent.ItemType<LowTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<BeginnerTransmutationRuneTile>())
                .Register();

            #endregion

            #region Mid Tier

            orePrice = 2;
            barPrice = 3;
            Recipe mid;
            mid = Recipe.Create(ItemID.CobaltOre)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();
            mid = Recipe.Create(ItemID.CobaltBar)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();

            mid = Recipe.Create(ItemID.PalladiumOre)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();
            mid = Recipe.Create(ItemID.PalladiumBar)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();

            orePrice = 3;
            barPrice = 4;
            mid = Recipe.Create(ItemID.MythrilOre)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();
            mid = Recipe.Create(ItemID.MythrilBar)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();

            mid = Recipe.Create(ItemID.OrichalcumOre)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();
            mid = Recipe.Create(ItemID.OrichalcumBar)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();

            orePrice = 5;
            barPrice = 4;
            mid = Recipe.Create(ItemID.AdamantiteOre)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();
            mid = Recipe.Create(ItemID.AdamantiteBar)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();

            mid = Recipe.Create(ItemID.TitaniumOre)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();
            mid = Recipe.Create(ItemID.TitaniumBar)
                .AddIngredient(ModContent.ItemType<IntermediateTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<IntermediateTransmutationRuneTile>())
                .Register();

            #endregion

            #region High Tier

            Recipe high;

            orePrice = 2;
            barPrice = 5;
            high = Recipe.Create(ItemID.ChlorophyteOre)
                .AddIngredient(ModContent.ItemType<AdvancedTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<AdvancedTransmutationRuneTile>())
                .Register();
            high = Recipe.Create(ItemID.ChlorophyteBar)
                .AddIngredient(ModContent.ItemType<AdvancedTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<AdvancedTransmutationRuneTile>())
                .Register();

            orePrice = 4;
            barPrice = 4;
            high = Recipe.Create(ItemID.LunarOre)
                .AddIngredient(ModContent.ItemType<AdvancedTierScrapOre>(), orePrice)
                .AddTile(ModContent.TileType<AdvancedTransmutationRuneTile>())
                .Register();
            high = Recipe.Create(ItemID.LunarBar)
                .AddIngredient(ModContent.ItemType<AdvancedTierScrapOre>(), orePrice * barPrice)
                .AddTile(ModContent.TileType<AdvancedTransmutationRuneTile>())
                .Register();

            #endregion
        }
    }
}