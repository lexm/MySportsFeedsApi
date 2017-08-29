using System.Collections.Generic;

namespace MySportsFeedsApi.Models.MLB
{
    public class ScoringPlay
    {
        public string teamAbbreviation { get; set; }
        public string playDescription { get; set; }
    }

    public class Scoring
    {
        public List<ScoringPlay> scoringPlay { get; set; }
    }

    

    public class InningTotals
    {
        public string awayScore { get; set; }
        public string homeScore { get; set; }
    }

    

    

    public class OpponentsLeftOnBase
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OpponentAtBats
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

   

    public class DefenceEfficiencyRatio
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    

    public class RunsFor
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsAgainst
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunDifferential
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class AwayTeamStats
    {
        public AtBats AtBats { get; set; }
        public Runs Runs { get; set; }
        public Hits Hits { get; set; }
        public SecondBaseHits SecondBaseHits { get; set; }
        public ThirdBaseHits ThirdBaseHits { get; set; }
        public Homeruns Homeruns { get; set; }
        public EarnedRuns EarnedRuns { get; set; }
        public UnearnedRuns UnearnedRuns { get; set; }
        public RunsBattedIn RunsBattedIn { get; set; }
        public BatterWalks BatterWalks { get; set; }
        public BatterSwings BatterSwings { get; set; }
        public BatterStrikes BatterStrikes { get; set; }
        public BatterStrikesFoul BatterStrikesFoul { get; set; }
        public BatterStrikesMiss BatterStrikesMiss { get; set; }
        public BatterStrikesLooking BatterStrikesLooking { get; set; }
        public BatterTagOuts BatterTagOuts { get; set; }
        public BatterForceOuts BatterForceOuts { get; set; }
        public BatterPutOuts BatterPutOuts { get; set; }
        public BatterGroundBalls BatterGroundBalls { get; set; }
        public BatterFlyBalls BatterFlyBalls { get; set; }
        public BatterLineDrives BatterLineDrives { get; set; }
        public Batter2SeamFastballs Batter2SeamFastballs { get; set; }
        public Batter4SeamFastballs Batter4SeamFastballs { get; set; }
        public BatterCurveballs BatterCurveballs { get; set; }
        public BatterChangeups BatterChangeups { get; set; }
        public BatterCutters BatterCutters { get; set; }
        public BatterSliders BatterSliders { get; set; }
        public BatterSinkers BatterSinkers { get; set; }
        public BatterSplitters BatterSplitters { get; set; }
        public BatterStrikeouts BatterStrikeouts { get; set; }
        public StolenBases StolenBases { get; set; }
        public CaughtBaseSteals CaughtBaseSteals { get; set; }
        public BatterStolenBasePct BatterStolenBasePct { get; set; }
        public BattingAvg BattingAvg { get; set; }
        public BatterOnBasePct BatterOnBasePct { get; set; }
        public BatterSluggingPct BatterSluggingPct { get; set; }
        public BatterOnBasePlusSluggingPct BatterOnBasePlusSluggingPct { get; set; }
        public BatterIntentionalWalks BatterIntentionalWalks { get; set; }
        public HitByPitch HitByPitch { get; set; }
        public BatterSacrificeBunts BatterSacrificeBunts { get; set; }
        public BatterSacrificeFlies BatterSacrificeFlies { get; set; }
        public TotalBases TotalBases { get; set; }
        public ExtraBaseHits ExtraBaseHits { get; set; }
        public BatterDoublePlays BatterDoublePlays { get; set; }
        public BatterTriplePlays BatterTriplePlays { get; set; }
        public BatterGroundOuts BatterGroundOuts { get; set; }
        public BatterFlyOuts BatterFlyOuts { get; set; }
        public BatterGroundOutToFlyOutRatio BatterGroundOutToFlyOutRatio { get; set; }
        public PitchesFaced PitchesFaced { get; set; }
        public PlateAppearances PlateAppearances { get; set; }
        public LeftOnBase LeftOnBase { get; set; }
        public OpponentsLeftOnBase OpponentsLeftOnBase { get; set; }
        public OpponentAtBats OpponentAtBats { get; set; }
        public SecondBaseHitsAllowed SecondBaseHitsAllowed { get; set; }
        public ThirdBaseHitsAllowed ThirdBaseHitsAllowed { get; set; }
        public PitcherSwings PitcherSwings { get; set; }
        public PitcherStrikes PitcherStrikes { get; set; }
        public PitcherStrikesFoul PitcherStrikesFoul { get; set; }
        public PitcherStrikesMiss PitcherStrikesMiss { get; set; }
        public PitcherStrikesLooking PitcherStrikesLooking { get; set; }
        public PitcherGroundBalls PitcherGroundBalls { get; set; }
        public PitcherFlyBalls PitcherFlyBalls { get; set; }
        public PitcherLineDrives PitcherLineDrives { get; set; }
        public Pitcher2SeamFastballs Pitcher2SeamFastballs { get; set; }
        public Pitcher4SeamFastballs Pitcher4SeamFastballs { get; set; }
        public PitcherCurveballs PitcherCurveballs { get; set; }
        public PitcherChangeups PitcherChangeups { get; set; }
        public PitcherCutters PitcherCutters { get; set; }
        public PitcherSliders PitcherSliders { get; set; }
        public PitcherSinkers PitcherSinkers { get; set; }
        public PitcherSplitters PitcherSplitters { get; set; }
        public PitcherSacrificeBunts PitcherSacrificeBunts { get; set; }
        public PitcherSacrificeFlies PitcherSacrificeFlies { get; set; }
        public EarnedRunAvg EarnedRunAvg { get; set; }
        public InningsPitched InningsPitched { get; set; }
        public HitsAllowed HitsAllowed { get; set; }
        public RunsAllowed RunsAllowed { get; set; }
        public EarnedRunsAllowed EarnedRunsAllowed { get; set; }
        public HomerunsAllowed HomerunsAllowed { get; set; }
        public PitcherWalks PitcherWalks { get; set; }
        public PitcherStrikeouts PitcherStrikeouts { get; set; }
        public PitchingAvg PitchingAvg { get; set; }
        public WalksAndHitsPerInningPitched WalksAndHitsPerInningPitched { get; set; }
        public Shutouts Shutouts { get; set; }
        public BattersHit BattersHit { get; set; }
        public PitcherIntentionalWalks PitcherIntentionalWalks { get; set; }
        public PitcherGroundOuts PitcherGroundOuts { get; set; }
        public PitcherFlyOuts PitcherFlyOuts { get; set; }
        public PitcherWildPitches PitcherWildPitches { get; set; }
        public Balks Balks { get; set; }
        public PitcherStolenBasesAllowed PitcherStolenBasesAllowed { get; set; }
        public PitcherCaughtStealing PitcherCaughtStealing { get; set; }
        public PickoffAttempts PickoffAttempts { get; set; }
        public Pickoffs Pickoffs { get; set; }
        public TotalBattersFaced TotalBattersFaced { get; set; }
        public PitchesThrown PitchesThrown { get; set; }
        public PitcherGroundOutToFlyOutRatio PitcherGroundOutToFlyOutRatio { get; set; }
        public PitcherOnBasePct PitcherOnBasePct { get; set; }
        public PitcherSluggingPct PitcherSluggingPct { get; set; }
        public PitcherOnBasePlusSluggingPct PitcherOnBasePlusSluggingPct { get; set; }
        public StrikeoutsPer9Innings StrikeoutsPer9Innings { get; set; }
        public WalksAllowedPer9Innings WalksAllowedPer9Innings { get; set; }
        public HitsAllowedPer9Innings HitsAllowedPer9Innings { get; set; }
        public StrikeoutsToWalksRatio StrikeoutsToWalksRatio { get; set; }
        public PitchesPerInning PitchesPerInning { get; set; }
        public InningsPlayed InningsPlayed { get; set; }
        public TotalChances TotalChances { get; set; }
        public FielderTagOuts FielderTagOuts { get; set; }
        public FielderForceOuts FielderForceOuts { get; set; }
        public FielderPutOuts FielderPutOuts { get; set; }
        public Assists Assists { get; set; }
        public Errors Errors { get; set; }
        public FielderDoublePlays FielderDoublePlays { get; set; }
        public FielderTriplePlays FielderTriplePlays { get; set; }
        public FielderStolenBasesAllowed FielderStolenBasesAllowed { get; set; }
        public FielderCaughtStealing FielderCaughtStealing { get; set; }
        public FielderStolenBasePct FielderStolenBasePct { get; set; }
        public PassedBalls PassedBalls { get; set; }
        public FielderWildPitches FielderWildPitches { get; set; }
        public FieldingPct FieldingPct { get; set; }
        public DefenceEfficiencyRatio DefenceEfficiencyRatio { get; set; }
        public OutsFaced OutsFaced { get; set; }
        public Wins Wins { get; set; }
        public Losses Losses { get; set; }
        public WinPct WinPct { get; set; }
        public RunsFor RunsFor { get; set; }
        public RunsAgainst RunsAgainst { get; set; }
        public RunDifferential RunDifferential { get; set; }
    }

    

    public class AtBats2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Runs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Hits2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SecondBaseHits2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdBaseHits2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Homeruns2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRuns2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class UnearnedRuns2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsBattedIn2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterWalks2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSwings2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikes2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesFoul2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesMiss2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesLooking2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterTagOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterForceOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterPutOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundBalls2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterFlyBalls2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterLineDrives2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Batter2SeamFastballs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Batter4SeamFastballs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterCurveballs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterChangeups2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterCutters2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSliders2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSinkers2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSplitters2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikeouts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StolenBases2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class CaughtBaseSteals2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStolenBasePct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BattingAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterOnBasePct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSluggingPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterOnBasePlusSluggingPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterIntentionalWalks2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitByPitch2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSacrificeBunts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSacrificeFlies2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalBases2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ExtraBaseHits2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterDoublePlays2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterTriplePlays2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterFlyOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundOutToFlyOutRatio2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesFaced2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PlateAppearances2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class LeftOnBase2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Wins2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Losses2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRunAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    

    public class InningsPitched2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitsAllowed2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SecondBaseHitsAllowed2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdBaseHitsAllowed2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsAllowed2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRunsAllowed2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HomerunsAllowed2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherWalks2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSwings2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikes2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesFoul2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesMiss2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesLooking2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundBalls2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherFlyBalls2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherLineDrives2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pitcher2SeamFastballs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pitcher4SeamFastballs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCurveballs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherChangeups2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCutters2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSliders2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSinkers2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSplitters2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSacrificeBunts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSacrificeFlies2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikeouts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchingAvg2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WalksAndHitsPerInningPitched2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }
    
    public class Shutouts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BattersHit2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherIntentionalWalks2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    
    public class PitcherGroundOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherFlyOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherWildPitches2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Balks2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStolenBasesAllowed2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCaughtStealing2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PickoffAttempts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pickoffs2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalBattersFaced2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesThrown2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WinPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundOutToFlyOutRatio2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherOnBasePct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSluggingPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherOnBasePlusSluggingPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StrikeoutsPer9Innings2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WalksAllowedPer9Innings2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitsAllowedPer9Innings2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StrikeoutsToWalksRatio2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesPerInning2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    

    public class InningsPlayed2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalChances2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderTagOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderForceOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderPutOuts2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OutsFaced2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Assists2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Errors2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderDoublePlays2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderTriplePlays2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderStolenBasesAllowed2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderCaughtStealing2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderStolenBasePct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassedBalls2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderWildPitches2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FieldingPct2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PlayerEntry
    {
        public Player player { get; set; }
        public Stats stats { get; set; }
    }

    public class AwayPlayers
    {
        public List<PlayerEntry> playerEntry { get; set; }
    }

    public class AwayTeam2
    {
        public AwayTeamStats awayTeamStats { get; set; }
        public AwayPlayers awayPlayers { get; set; }
    }

    public class AtBats3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Runs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Hits3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SecondBaseHits3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdBaseHits3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Homeruns3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRuns3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class UnearnedRuns3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsBattedIn3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterWalks3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSwings3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikes3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesFoul3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesMiss3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesLooking3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterTagOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterForceOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterPutOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundBalls3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterFlyBalls3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterLineDrives3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Batter2SeamFastballs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Batter4SeamFastballs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterCurveballs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterChangeups3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterCutters3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSliders3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSinkers3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSplitters3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikeouts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StolenBases3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class CaughtBaseSteals3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStolenBasePct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BattingAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterOnBasePct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSluggingPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterOnBasePlusSluggingPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterIntentionalWalks3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitByPitch3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSacrificeBunts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSacrificeFlies3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalBases3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ExtraBaseHits3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterDoublePlays3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterTriplePlays3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterFlyOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundOutToFlyOutRatio3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesFaced3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PlateAppearances3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class LeftOnBase3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OpponentsLeftOnBase2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OpponentAtBats2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SecondBaseHitsAllowed3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdBaseHitsAllowed3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSwings3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikes3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesFoul3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesMiss3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesLooking3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundBalls3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherFlyBalls3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherLineDrives3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pitcher2SeamFastballs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pitcher4SeamFastballs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCurveballs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherChangeups3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCutters3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSliders3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSinkers3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSplitters3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSacrificeBunts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSacrificeFlies3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRunAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class InningsPitched3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitsAllowed3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsAllowed3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRunsAllowed3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HomerunsAllowed3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherWalks3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikeouts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchingAvg3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WalksAndHitsPerInningPitched3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Shutouts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BattersHit3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherIntentionalWalks3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherFlyOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherWildPitches3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Balks3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStolenBasesAllowed3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCaughtStealing3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PickoffAttempts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pickoffs3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalBattersFaced3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesThrown3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundOutToFlyOutRatio3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherOnBasePct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSluggingPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherOnBasePlusSluggingPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StrikeoutsPer9Innings3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WalksAllowedPer9Innings3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitsAllowedPer9Innings3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StrikeoutsToWalksRatio3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesPerInning3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class InningsPlayed3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalChances3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderTagOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderForceOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderPutOuts3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Assists3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Errors3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderDoublePlays3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderTriplePlays3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderStolenBasesAllowed3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderCaughtStealing3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderStolenBasePct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassedBalls3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderWildPitches3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FieldingPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class DefenceEfficiencyRatio2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OutsFaced3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Wins3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Losses3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WinPct3
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsFor2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsAgainst2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunDifferential2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HomeTeamStats
    {
        public AtBats3 AtBats { get; set; }
        public Runs3 Runs { get; set; }
        public Hits3 Hits { get; set; }
        public SecondBaseHits3 SecondBaseHits { get; set; }
        public ThirdBaseHits3 ThirdBaseHits { get; set; }
        public Homeruns3 Homeruns { get; set; }
        public EarnedRuns3 EarnedRuns { get; set; }
        public UnearnedRuns3 UnearnedRuns { get; set; }
        public RunsBattedIn3 RunsBattedIn { get; set; }
        public BatterWalks3 BatterWalks { get; set; }
        public BatterSwings3 BatterSwings { get; set; }
        public BatterStrikes3 BatterStrikes { get; set; }
        public BatterStrikesFoul3 BatterStrikesFoul { get; set; }
        public BatterStrikesMiss3 BatterStrikesMiss { get; set; }
        public BatterStrikesLooking3 BatterStrikesLooking { get; set; }
        public BatterTagOuts3 BatterTagOuts { get; set; }
        public BatterForceOuts3 BatterForceOuts { get; set; }
        public BatterPutOuts3 BatterPutOuts { get; set; }
        public BatterGroundBalls3 BatterGroundBalls { get; set; }
        public BatterFlyBalls3 BatterFlyBalls { get; set; }
        public BatterLineDrives3 BatterLineDrives { get; set; }
        public Batter2SeamFastballs3 Batter2SeamFastballs { get; set; }
        public Batter4SeamFastballs3 Batter4SeamFastballs { get; set; }
        public BatterCurveballs3 BatterCurveballs { get; set; }
        public BatterChangeups3 BatterChangeups { get; set; }
        public BatterCutters3 BatterCutters { get; set; }
        public BatterSliders3 BatterSliders { get; set; }
        public BatterSinkers3 BatterSinkers { get; set; }
        public BatterSplitters3 BatterSplitters { get; set; }
        public BatterStrikeouts3 BatterStrikeouts { get; set; }
        public StolenBases3 StolenBases { get; set; }
        public CaughtBaseSteals3 CaughtBaseSteals { get; set; }
        public BatterStolenBasePct3 BatterStolenBasePct { get; set; }
        public BattingAvg3 BattingAvg { get; set; }
        public BatterOnBasePct3 BatterOnBasePct { get; set; }
        public BatterSluggingPct3 BatterSluggingPct { get; set; }
        public BatterOnBasePlusSluggingPct3 BatterOnBasePlusSluggingPct { get; set; }
        public BatterIntentionalWalks3 BatterIntentionalWalks { get; set; }
        public HitByPitch3 HitByPitch { get; set; }
        public BatterSacrificeBunts3 BatterSacrificeBunts { get; set; }
        public BatterSacrificeFlies3 BatterSacrificeFlies { get; set; }
        public TotalBases3 TotalBases { get; set; }
        public ExtraBaseHits3 ExtraBaseHits { get; set; }
        public BatterDoublePlays3 BatterDoublePlays { get; set; }
        public BatterTriplePlays3 BatterTriplePlays { get; set; }
        public BatterGroundOuts3 BatterGroundOuts { get; set; }
        public BatterFlyOuts3 BatterFlyOuts { get; set; }
        public BatterGroundOutToFlyOutRatio3 BatterGroundOutToFlyOutRatio { get; set; }
        public PitchesFaced3 PitchesFaced { get; set; }
        public PlateAppearances3 PlateAppearances { get; set; }
        public LeftOnBase3 LeftOnBase { get; set; }
        public OpponentsLeftOnBase2 OpponentsLeftOnBase { get; set; }
        public OpponentAtBats2 OpponentAtBats { get; set; }
        public SecondBaseHitsAllowed3 SecondBaseHitsAllowed { get; set; }
        public ThirdBaseHitsAllowed3 ThirdBaseHitsAllowed { get; set; }
        public PitcherSwings3 PitcherSwings { get; set; }
        public PitcherStrikes3 PitcherStrikes { get; set; }
        public PitcherStrikesFoul3 PitcherStrikesFoul { get; set; }
        public PitcherStrikesMiss3 PitcherStrikesMiss { get; set; }
        public PitcherStrikesLooking3 PitcherStrikesLooking { get; set; }
        public PitcherGroundBalls3 PitcherGroundBalls { get; set; }
        public PitcherFlyBalls3 PitcherFlyBalls { get; set; }
        public PitcherLineDrives3 PitcherLineDrives { get; set; }
        public Pitcher2SeamFastballs3 Pitcher2SeamFastballs { get; set; }
        public Pitcher4SeamFastballs3 Pitcher4SeamFastballs { get; set; }
        public PitcherCurveballs3 PitcherCurveballs { get; set; }
        public PitcherChangeups3 PitcherChangeups { get; set; }
        public PitcherCutters3 PitcherCutters { get; set; }
        public PitcherSliders3 PitcherSliders { get; set; }
        public PitcherSinkers3 PitcherSinkers { get; set; }
        public PitcherSplitters3 PitcherSplitters { get; set; }
        public PitcherSacrificeBunts3 PitcherSacrificeBunts { get; set; }
        public PitcherSacrificeFlies3 PitcherSacrificeFlies { get; set; }
        public EarnedRunAvg3 EarnedRunAvg { get; set; }
        public InningsPitched3 InningsPitched { get; set; }
        public HitsAllowed3 HitsAllowed { get; set; }
        public RunsAllowed3 RunsAllowed { get; set; }
        public EarnedRunsAllowed3 EarnedRunsAllowed { get; set; }
        public HomerunsAllowed3 HomerunsAllowed { get; set; }
        public PitcherWalks3 PitcherWalks { get; set; }
        public PitcherStrikeouts3 PitcherStrikeouts { get; set; }
        public PitchingAvg3 PitchingAvg { get; set; }
        public WalksAndHitsPerInningPitched3 WalksAndHitsPerInningPitched { get; set; }
        public Shutouts3 Shutouts { get; set; }
        public BattersHit3 BattersHit { get; set; }
        public PitcherIntentionalWalks3 PitcherIntentionalWalks { get; set; }
        public PitcherGroundOuts3 PitcherGroundOuts { get; set; }
        public PitcherFlyOuts3 PitcherFlyOuts { get; set; }
        public PitcherWildPitches3 PitcherWildPitches { get; set; }
        public Balks3 Balks { get; set; }
        public PitcherStolenBasesAllowed3 PitcherStolenBasesAllowed { get; set; }
        public PitcherCaughtStealing3 PitcherCaughtStealing { get; set; }
        public PickoffAttempts3 PickoffAttempts { get; set; }
        public Pickoffs3 Pickoffs { get; set; }
        public TotalBattersFaced3 TotalBattersFaced { get; set; }
        public PitchesThrown3 PitchesThrown { get; set; }
        public PitcherGroundOutToFlyOutRatio3 PitcherGroundOutToFlyOutRatio { get; set; }
        public PitcherOnBasePct3 PitcherOnBasePct { get; set; }
        public PitcherSluggingPct3 PitcherSluggingPct { get; set; }
        public PitcherOnBasePlusSluggingPct3 PitcherOnBasePlusSluggingPct { get; set; }
        public StrikeoutsPer9Innings3 StrikeoutsPer9Innings { get; set; }
        public WalksAllowedPer9Innings3 WalksAllowedPer9Innings { get; set; }
        public HitsAllowedPer9Innings3 HitsAllowedPer9Innings { get; set; }
        public StrikeoutsToWalksRatio3 StrikeoutsToWalksRatio { get; set; }
        public PitchesPerInning3 PitchesPerInning { get; set; }
        public InningsPlayed3 InningsPlayed { get; set; }
        public TotalChances3 TotalChances { get; set; }
        public FielderTagOuts3 FielderTagOuts { get; set; }
        public FielderForceOuts3 FielderForceOuts { get; set; }
        public FielderPutOuts3 FielderPutOuts { get; set; }
        public Assists3 Assists { get; set; }
        public Errors3 Errors { get; set; }
        public FielderDoublePlays3 FielderDoublePlays { get; set; }
        public FielderTriplePlays3 FielderTriplePlays { get; set; }
        public FielderStolenBasesAllowed3 FielderStolenBasesAllowed { get; set; }
        public FielderCaughtStealing3 FielderCaughtStealing { get; set; }
        public FielderStolenBasePct3 FielderStolenBasePct { get; set; }
        public PassedBalls3 PassedBalls { get; set; }
        public FielderWildPitches3 FielderWildPitches { get; set; }
        public FieldingPct3 FieldingPct { get; set; }
        public DefenceEfficiencyRatio2 DefenceEfficiencyRatio { get; set; }
        public OutsFaced3 OutsFaced { get; set; }
        public Wins3 Wins { get; set; }
        public Losses3 Losses { get; set; }
        public WinPct3 WinPct { get; set; }
        public RunsFor2 RunsFor { get; set; }
        public RunsAgainst2 RunsAgainst { get; set; }
        public RunDifferential2 RunDifferential { get; set; }
    }

    public class Player2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class AtBats4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Runs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Hits4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SecondBaseHits4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdBaseHits4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Homeruns4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRuns4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class UnearnedRuns4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsBattedIn4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterWalks4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSwings4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikes4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesFoul4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesMiss4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesLooking4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterTagOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterForceOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterPutOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundBalls4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterFlyBalls4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterLineDrives4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Batter2SeamFastballs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Batter4SeamFastballs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterCurveballs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterChangeups4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterCutters4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSliders4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSinkers4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSplitters4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikeouts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StolenBases4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class CaughtBaseSteals4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStolenBasePct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BattingAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterOnBasePct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSluggingPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterOnBasePlusSluggingPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterIntentionalWalks4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitByPitch4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSacrificeBunts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSacrificeFlies4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalBases4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ExtraBaseHits4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterDoublePlays4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterTriplePlays4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterFlyOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundOutToFlyOutRatio4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesFaced4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PlateAppearances4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class LeftOnBase4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Wins4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Losses4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRunAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Saves2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SaveOpportunities2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class InningsPitched4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitsAllowed4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SecondBaseHitsAllowed4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdBaseHitsAllowed4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsAllowed4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRunsAllowed4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HomerunsAllowed4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherWalks4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSwings4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikes4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesFoul4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesMiss4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesLooking4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundBalls4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherFlyBalls4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherLineDrives4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pitcher2SeamFastballs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pitcher4SeamFastballs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCurveballs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherChangeups4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCutters4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSliders4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSinkers4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSplitters4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSacrificeBunts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSacrificeFlies4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikeouts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchingAvg4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WalksAndHitsPerInningPitched4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class CompletedGames2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Shutouts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BattersHit4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherIntentionalWalks4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class GamesFinished2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Holds2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherDoublePlays2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherTriplePlays2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherFlyOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherWildPitches4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Balks4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStolenBasesAllowed4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCaughtStealing4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PickoffAttempts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pickoffs4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalBattersFaced4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesThrown4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WinPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundOutToFlyOutRatio4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherOnBasePct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSluggingPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherOnBasePlusSluggingPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StrikeoutsPer9Innings4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WalksAllowedPer9Innings4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitsAllowedPer9Innings4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StrikeoutsToWalksRatio4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesPerInning4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherAtBats2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class InningsPlayed4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalChances4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderTagOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderForceOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderPutOuts4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OutsFaced4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Assists4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Errors4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderDoublePlays4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderTriplePlays4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderStolenBasesAllowed4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderCaughtStealing4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderStolenBasePct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassedBalls4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderWildPitches4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FieldingPct4
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RangeFactor2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class GamesStarted2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stats2
    {
        public AtBats4 AtBats { get; set; }
        public Runs4 Runs { get; set; }
        public Hits4 Hits { get; set; }
        public SecondBaseHits4 SecondBaseHits { get; set; }
        public ThirdBaseHits4 ThirdBaseHits { get; set; }
        public Homeruns4 Homeruns { get; set; }
        public EarnedRuns4 EarnedRuns { get; set; }
        public UnearnedRuns4 UnearnedRuns { get; set; }
        public RunsBattedIn4 RunsBattedIn { get; set; }
        public BatterWalks4 BatterWalks { get; set; }
        public BatterSwings4 BatterSwings { get; set; }
        public BatterStrikes4 BatterStrikes { get; set; }
        public BatterStrikesFoul4 BatterStrikesFoul { get; set; }
        public BatterStrikesMiss4 BatterStrikesMiss { get; set; }
        public BatterStrikesLooking4 BatterStrikesLooking { get; set; }
        public BatterTagOuts4 BatterTagOuts { get; set; }
        public BatterForceOuts4 BatterForceOuts { get; set; }
        public BatterPutOuts4 BatterPutOuts { get; set; }
        public BatterGroundBalls4 BatterGroundBalls { get; set; }
        public BatterFlyBalls4 BatterFlyBalls { get; set; }
        public BatterLineDrives4 BatterLineDrives { get; set; }
        public Batter2SeamFastballs4 Batter2SeamFastballs { get; set; }
        public Batter4SeamFastballs4 Batter4SeamFastballs { get; set; }
        public BatterCurveballs4 BatterCurveballs { get; set; }
        public BatterChangeups4 BatterChangeups { get; set; }
        public BatterCutters4 BatterCutters { get; set; }
        public BatterSliders4 BatterSliders { get; set; }
        public BatterSinkers4 BatterSinkers { get; set; }
        public BatterSplitters4 BatterSplitters { get; set; }
        public BatterStrikeouts4 BatterStrikeouts { get; set; }
        public StolenBases4 StolenBases { get; set; }
        public CaughtBaseSteals4 CaughtBaseSteals { get; set; }
        public BatterStolenBasePct4 BatterStolenBasePct { get; set; }
        public BattingAvg4 BattingAvg { get; set; }
        public BatterOnBasePct4 BatterOnBasePct { get; set; }
        public BatterSluggingPct4 BatterSluggingPct { get; set; }
        public BatterOnBasePlusSluggingPct4 BatterOnBasePlusSluggingPct { get; set; }
        public BatterIntentionalWalks4 BatterIntentionalWalks { get; set; }
        public HitByPitch4 HitByPitch { get; set; }
        public BatterSacrificeBunts4 BatterSacrificeBunts { get; set; }
        public BatterSacrificeFlies4 BatterSacrificeFlies { get; set; }
        public TotalBases4 TotalBases { get; set; }
        public ExtraBaseHits4 ExtraBaseHits { get; set; }
        public BatterDoublePlays4 BatterDoublePlays { get; set; }
        public BatterTriplePlays4 BatterTriplePlays { get; set; }
        public BatterGroundOuts4 BatterGroundOuts { get; set; }
        public BatterFlyOuts4 BatterFlyOuts { get; set; }
        public BatterGroundOutToFlyOutRatio4 BatterGroundOutToFlyOutRatio { get; set; }
        public PitchesFaced4 PitchesFaced { get; set; }
        public PlateAppearances4 PlateAppearances { get; set; }
        public LeftOnBase4 LeftOnBase { get; set; }
        public Wins4 Wins { get; set; }
        public Losses4 Losses { get; set; }
        public EarnedRunAvg4 EarnedRunAvg { get; set; }
        public Saves2 Saves { get; set; }
        public SaveOpportunities2 SaveOpportunities { get; set; }
        public InningsPitched4 InningsPitched { get; set; }
        public HitsAllowed4 HitsAllowed { get; set; }
        public SecondBaseHitsAllowed4 SecondBaseHitsAllowed { get; set; }
        public ThirdBaseHitsAllowed4 ThirdBaseHitsAllowed { get; set; }
        public RunsAllowed4 RunsAllowed { get; set; }
        public EarnedRunsAllowed4 EarnedRunsAllowed { get; set; }
        public HomerunsAllowed4 HomerunsAllowed { get; set; }
        public PitcherWalks4 PitcherWalks { get; set; }
        public PitcherSwings4 PitcherSwings { get; set; }
        public PitcherStrikes4 PitcherStrikes { get; set; }
        public PitcherStrikesFoul4 PitcherStrikesFoul { get; set; }
        public PitcherStrikesMiss4 PitcherStrikesMiss { get; set; }
        public PitcherStrikesLooking4 PitcherStrikesLooking { get; set; }
        public PitcherGroundBalls4 PitcherGroundBalls { get; set; }
        public PitcherFlyBalls4 PitcherFlyBalls { get; set; }
        public PitcherLineDrives4 PitcherLineDrives { get; set; }
        public Pitcher2SeamFastballs4 Pitcher2SeamFastballs { get; set; }
        public Pitcher4SeamFastballs4 Pitcher4SeamFastballs { get; set; }
        public PitcherCurveballs4 PitcherCurveballs { get; set; }
        public PitcherChangeups4 PitcherChangeups { get; set; }
        public PitcherCutters4 PitcherCutters { get; set; }
        public PitcherSliders4 PitcherSliders { get; set; }
        public PitcherSinkers4 PitcherSinkers { get; set; }
        public PitcherSplitters4 PitcherSplitters { get; set; }
        public PitcherSacrificeBunts4 PitcherSacrificeBunts { get; set; }
        public PitcherSacrificeFlies4 PitcherSacrificeFlies { get; set; }
        public PitcherStrikeouts4 PitcherStrikeouts { get; set; }
        public PitchingAvg4 PitchingAvg { get; set; }
        public WalksAndHitsPerInningPitched4 WalksAndHitsPerInningPitched { get; set; }
        public CompletedGames2 CompletedGames { get; set; }
        public Shutouts4 Shutouts { get; set; }
        public BattersHit4 BattersHit { get; set; }
        public PitcherIntentionalWalks4 PitcherIntentionalWalks { get; set; }
        public GamesFinished2 GamesFinished { get; set; }
        public Holds2 Holds { get; set; }
        public PitcherDoublePlays2 PitcherDoublePlays { get; set; }
        public PitcherTriplePlays2 PitcherTriplePlays { get; set; }
        public PitcherGroundOuts4 PitcherGroundOuts { get; set; }
        public PitcherFlyOuts4 PitcherFlyOuts { get; set; }
        public PitcherWildPitches4 PitcherWildPitches { get; set; }
        public Balks4 Balks { get; set; }
        public PitcherStolenBasesAllowed4 PitcherStolenBasesAllowed { get; set; }
        public PitcherCaughtStealing4 PitcherCaughtStealing { get; set; }
        public PickoffAttempts4 PickoffAttempts { get; set; }
        public Pickoffs4 Pickoffs { get; set; }
        public TotalBattersFaced4 TotalBattersFaced { get; set; }
        public PitchesThrown4 PitchesThrown { get; set; }
        public WinPct4 WinPct { get; set; }
        public PitcherGroundOutToFlyOutRatio4 PitcherGroundOutToFlyOutRatio { get; set; }
        public PitcherOnBasePct4 PitcherOnBasePct { get; set; }
        public PitcherSluggingPct4 PitcherSluggingPct { get; set; }
        public PitcherOnBasePlusSluggingPct4 PitcherOnBasePlusSluggingPct { get; set; }
        public StrikeoutsPer9Innings4 StrikeoutsPer9Innings { get; set; }
        public WalksAllowedPer9Innings4 WalksAllowedPer9Innings { get; set; }
        public HitsAllowedPer9Innings4 HitsAllowedPer9Innings { get; set; }
        public StrikeoutsToWalksRatio4 StrikeoutsToWalksRatio { get; set; }
        public PitchesPerInning4 PitchesPerInning { get; set; }
        public PitcherAtBats2 PitcherAtBats { get; set; }
        public InningsPlayed4 InningsPlayed { get; set; }
        public TotalChances4 TotalChances { get; set; }
        public FielderTagOuts4 FielderTagOuts { get; set; }
        public FielderForceOuts4 FielderForceOuts { get; set; }
        public FielderPutOuts4 FielderPutOuts { get; set; }
        public OutsFaced4 OutsFaced { get; set; }
        public Assists4 Assists { get; set; }
        public Errors4 Errors { get; set; }
        public FielderDoublePlays4 FielderDoublePlays { get; set; }
        public FielderTriplePlays4 FielderTriplePlays { get; set; }
        public FielderStolenBasesAllowed4 FielderStolenBasesAllowed { get; set; }
        public FielderCaughtStealing4 FielderCaughtStealing { get; set; }
        public FielderStolenBasePct4 FielderStolenBasePct { get; set; }
        public PassedBalls4 PassedBalls { get; set; }
        public FielderWildPitches4 FielderWildPitches { get; set; }
        public FieldingPct4 FieldingPct { get; set; }
        public RangeFactor2 RangeFactor { get; set; }
        public GamesStarted2 GamesStarted { get; set; }
    }

    public class PlayerEntry2
    {
        public Player2 player { get; set; }
        public Stats2 stats { get; set; }
    }

    public class HomePlayers
    {
        public List<PlayerEntry2> playerEntry { get; set; }
    }

    public class HomeTeam2
    {
        public HomeTeamStats homeTeamStats { get; set; }
        public HomePlayers homePlayers { get; set; }
    }

    public class Boxscore
    {
        public string lastUpdatedOn { get; set; }
        public Game game { get; set; }
        public InningSummary inningSummary { get; set; }
        public AwayTeam2 awayTeam { get; set; }
        public HomeTeam2 homeTeam { get; set; }
    }

    public class GameBoxscore : IFeedRoot
    {
        public Boxscore gameboxscore { get; set; }
    }
}