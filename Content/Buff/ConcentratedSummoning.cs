using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Buff
{
    public class ConcentratedSummoning : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Concentrated Summoning");
            Description.SetDefault("Increased max number of minions by 2");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.HasBuff(BuffID.Summoning))
                player.ClearBuff(BuffID.Summoning);

            player.maxMinions += 2;
        }
    }
}