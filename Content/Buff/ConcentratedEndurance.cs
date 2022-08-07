using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Buff
{
    public class ConcentratedEndurance : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Concentrated Endurance");
            Description.SetDefault("Reduces damage taken by 20%");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.HasBuff(BuffID.Endurance))
                player.ClearBuff(BuffID.Endurance);

            player.endurance += 0.2f;
        }
    }
}