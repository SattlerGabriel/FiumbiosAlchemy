using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Buff
{
    public class LesserLifeforce : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lesser Lifeforce");
            Description.SetDefault("10% increased max life");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.HasBuff(BuffID.Lifeforce))
                player.ClearBuff(ModContent.BuffType<LesserLifeforce>());

            player.statLifeMax2 += (int)Math.Round(player.statLifeMax * 0.1);
        }
    }
}