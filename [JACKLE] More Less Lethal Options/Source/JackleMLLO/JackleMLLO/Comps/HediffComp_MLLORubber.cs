using UnityEngine;
using Verse;

namespace JackleMLLO
{
    public class HediffComp_MLLORubber : HediffComp
    {
        public HediffCompProperties_MLLORubber Props => props as HediffCompProperties_MLLORubber;

        public override void CompPostPostAdd(DamageInfo? dinfo)
        {
            base.CompPostPostAdd(dinfo);

            if (parent.pawn.RaceProps.IsMechanoid)
            {
                return;
            }

            var severity = Props.BaseSeverityPerDamage * parent.Severity / Mathf.Pow(parent.pawn.HealthScale, 2);
            HealthUtility.AdjustSeverity(parent.pawn, MLLO_HediffDefOf.RubberImpact, severity);
        }
    }
}
