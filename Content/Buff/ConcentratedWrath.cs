using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FiumbiosAlchemy.Content.Buff
{
    public class ConcentratedWrath : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Concentrated Wrath");
            Description.SetDefault("Increased damage by 20%");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.HasBuff(BuffID.Wrath))
                player.ClearBuff(BuffID.Wrath);

            player.GetDamage(DamageClass.Generic) += 0.2f;
        }
    }
}