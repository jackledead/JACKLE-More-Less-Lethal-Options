using Verse;

namespace JackleMLLO
{
public class HediffCompProperties_MLLORubber : HediffCompProperties
{
  public float BaseSeverityPerDamage = 0.012f;
//   .012 severity to rubber impact hediff per point of dmg
  
  public HediffCompProperties_MLLORubber()
  {
    compClass = typeof(HediffComp_MLLORubber); 
  }
}
}