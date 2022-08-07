using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Buff
{
    public class ConcentratedArchery : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Concentrated Archery");
            Description.SetDefault("20% increased arrow speed and 40% increased arrow damage");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.HasBuff(BuffID.Archery))
                player.ClearBuff(BuffID.Archery);

            player.arrowDamage *= 1.4f;
            player.archery = true;
        }
    }
}