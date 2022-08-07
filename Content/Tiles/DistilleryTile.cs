using FiumbiosAlchemy.Content.Items.Placeable;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace FiumbiosAlchemy.Content.Tiles
{
  public class DistilleryTile : ModTile
  {
    public override void SetStaticDefaults()
    {
      Main.tileFrameImportant[Type] = true;
      Main.tileNoAttach[Type] = true;
      Main.placementPreview = true;
      Main.tilePile[Type] = true;
      DustType = 8;

      ModTranslation name = CreateMapEntryName();
      name.SetDefault("Distillery");
      AddMapEntry(new Color(200, 200, 200), name);

      TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
      TileObjectData.addTile(Type);
    }

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
      Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32,
        ModContent.ItemType<DistilleryItem>());
    }
  }
}