using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Buff
{
    public class ConcentratedIronskin : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Concentrated Ironskin");
            Description.SetDefault("Increases your defense by 30");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.HasBuff(BuffID.Ironskin))
                player.ClearBuff(BuffID.Ironskin);

            player.statDefense += 30;
        }
    }
}