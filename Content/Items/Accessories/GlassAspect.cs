using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Accessories;

public class GlassAspect : ModItem
{
  public override void SetStaticDefaults()
  {
    DisplayName.SetDefault("Glass Aspect");
    Tooltip.SetDefault("Gain twice your damage at the cost of half of your max health");
  }

  public override void SetDefaults()
  {
    Item.width = 44;
    Item.height = 44;
    Item.accessory = true;
    Item.rare = ItemRarityID.LightRed;
    Item.value = 10000;
  }

  public override void UpdateAccessory(Player player, bool hideVisual)
  {
    player.statLifeMax2 = player.statLifeMax2 / 2;
    player.GetDamage<GenericDamageClass>() *= 2;
  }

  public override void AddRecipes()
  {
    Recipe recipe = CreateRecipe()
      .AddIngredient(ItemID.Glass, 50)
      .AddTile(TileID.Furnaces)
      .Register();
  }
}