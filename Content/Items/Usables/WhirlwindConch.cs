using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Items.Usables
{
  public class WhirlwindConch : ModItem
  {
    public override void SetStaticDefaults()
    {
      Tooltip.SetDefault("Left click to teleport to the ocean" +
                         "\nRight click to teleport to the underworld");
    }

    public override void SetDefaults()
    {
      Item.width = 38;
      Item.height = 40;
      Item.maxStack = 1;
      Item.value = 500 * 5;
      Item.rare = ItemRarityID.Pink;
      Item.useStyle = ItemUseStyleID.HoldUp;
      Item.useTurn = true;
      Item.UseSound = SoundID.Item6;
    }

    public override bool AltFunctionUse(Player player)
    {
      return true;
    }

    public override void UseStyle(Player player, Rectangle heldItemFrame)
    {
      var altUse = player.altFunctionUse;
      var color = altUse == 2 ? Color.Red : Color.Blue;

      if (Main.rand.NextBool())
      {
        Dust.NewDust(player.position, player.width, player.height, DustID.MagicMirror,
          0,
          0, 150, color, 1.5f);
      }

      if (player.itemTime == 0)
      {
        player.itemTime = (int)(Item.useTime / UseTimeMultiplier(player));
      }
      else if (player.itemTime == (int)(Item.useTime / UseTimeMultiplier(player)) / 2)
      {
        for (var d = 0; d < 70; d++)
        {
          Dust.NewDust(player.position, player.width, player.height, DustID.MagicMirror,
            player.velocity.X * 0.5f,
            player.velocity.Y * 0.5f, 150, color, 1.5f);
        }

        player.grappling[0] = -1;
        player.grapCount = 0;
        for (var p = 0; p < 1000; p++)
        {
          if (Main.projectile[p].active && Main.projectile[p].owner == player.whoAmI &&
              Main.projectile[p].aiStyle == 7)
          {
            Main.projectile[p].Kill();
          }
        }

        if (altUse == 2)
        {
          player.DemonConch();

          for (var d = 0; d < 70; d++)
          {
            Dust.NewDust(player.position, player.width, player.height, DustID.MagicMirror,
              player.velocity.X * 0.5f,
              player.velocity.Y * 0.5f, 150, color, 1.5f);
          }

          return;
        }

        player.MagicConch();

        for (var d = 0; d < 70; d++)
        {
          Dust.NewDust(player.position, player.width, player.height, DustID.MagicMirror,
            player.velocity.X * 0.5f,
            player.velocity.Y * 0.5f, 150, color, 1.5f);
        }
      }
    }

    public override void AddRecipes()
    {
      Recipe recipe = CreateRecipe()
        .AddIngredient(ItemID.LargeAmber)
        .AddIngredient(ItemID.MagicConch)
        .AddIngredient(ItemID.DemonConch)
        .AddTile(TileID.WorkBenches)
        .Register();
    }
  }
}