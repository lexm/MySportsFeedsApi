using System.Collections.Generic;

namespace MySportsFeedsApi.Models.MLB
{
    public class Player
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class Team
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

    public class GamesPlayed
    {
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class AtBats
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Runs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Hits
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SecondBaseHits
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdBaseHits
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Homeruns
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRuns
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class UnearnedRuns
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsBattedIn
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterWalks
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSwings
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikes
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesFoul
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesMiss
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikesLooking
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterTagOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterForceOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterPutOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundBalls
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterFlyBalls
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterLineDrives
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Batter2SeamFastballs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Batter4SeamFastballs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterCurveballs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterChangeups
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterCutters
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSliders
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSinkers
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSplitters
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStrikeouts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StolenBases
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class CaughtBaseSteals
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterStolenBasePct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BattingAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterOnBasePct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSluggingPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterOnBasePlusSluggingPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterIntentionalWalks
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitByPitch
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSacrificeBunts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterSacrificeFlies
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalBases
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ExtraBaseHits
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterDoublePlays
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterTriplePlays
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterFlyOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BatterGroundOutToFlyOutRatio
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesFaced
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PlateAppearances
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class LeftOnBase
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class InningsPlayed
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalChances
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderTagOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderForceOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderPutOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OutsFaced
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Assists
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Errors
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderDoublePlays
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderTriplePlays
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderStolenBasesAllowed
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderCaughtStealing
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderStolenBasePct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PassedBalls
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FielderWildPitches
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FieldingPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RangeFactor
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class GamesStarted
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Wins
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Losses
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRunAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Saves
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SaveOpportunities
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class InningsPitched
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitsAllowed
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class SecondBaseHitsAllowed
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class ThirdBaseHitsAllowed
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RunsAllowed
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class EarnedRunsAllowed
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HomerunsAllowed
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherWalks
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSwings
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikes
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesFoul
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesMiss
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikesLooking
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundBalls
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherFlyBalls
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherLineDrives
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pitcher2SeamFastballs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pitcher4SeamFastballs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCurveballs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherChangeups
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCutters
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSliders
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSinkers
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSplitters
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSacrificeBunts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSacrificeFlies
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStrikeouts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchingAvg
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WalksAndHitsPerInningPitched
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class CompletedGames
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Shutouts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BattersHit
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherIntentionalWalks
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class GamesFinished
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Holds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherDoublePlays
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherTriplePlays
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherFlyOuts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherWildPitches
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Balks
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherStolenBasesAllowed
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherCaughtStealing
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PickoffAttempts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pickoffs
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TotalBattersFaced
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesThrown
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WinPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherGroundOutToFlyOutRatio
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherOnBasePct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherSluggingPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherOnBasePlusSluggingPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StrikeoutsPer9Innings
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class WalksAllowedPer9Innings
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class HitsAllowedPer9Innings
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StrikeoutsToWalksRatio
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitchesPerInning
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PitcherAtBats
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stats
    {
        public GamesPlayed GamesPlayed { get; set; }
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
        public InningsPlayed InningsPlayed { get; set; }
        public TotalChances TotalChances { get; set; }
        public FielderTagOuts FielderTagOuts { get; set; }
        public FielderForceOuts FielderForceOuts { get; set; }
        public FielderPutOuts FielderPutOuts { get; set; }
        public OutsFaced OutsFaced { get; set; }
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
        public RangeFactor RangeFactor { get; set; }
        public GamesStarted GamesStarted { get; set; }
        public Wins Wins { get; set; }
        public Losses Losses { get; set; }
        public EarnedRunAvg EarnedRunAvg { get; set; }
        public Saves Saves { get; set; }
        public SaveOpportunities SaveOpportunities { get; set; }
        public InningsPitched InningsPitched { get; set; }
        public HitsAllowed HitsAllowed { get; set; }
        public SecondBaseHitsAllowed SecondBaseHitsAllowed { get; set; }
        public ThirdBaseHitsAllowed ThirdBaseHitsAllowed { get; set; }
        public RunsAllowed RunsAllowed { get; set; }
        public EarnedRunsAllowed EarnedRunsAllowed { get; set; }
        public HomerunsAllowed HomerunsAllowed { get; set; }
        public PitcherWalks PitcherWalks { get; set; }
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
        public PitcherStrikeouts PitcherStrikeouts { get; set; }
        public PitchingAvg PitchingAvg { get; set; }
        public WalksAndHitsPerInningPitched WalksAndHitsPerInningPitched { get; set; }
        public CompletedGames CompletedGames { get; set; }
        public Shutouts Shutouts { get; set; }
        public BattersHit BattersHit { get; set; }
        public PitcherIntentionalWalks PitcherIntentionalWalks { get; set; }
        public GamesFinished GamesFinished { get; set; }
        public Holds Holds { get; set; }
        public PitcherDoublePlays PitcherDoublePlays { get; set; }
        public PitcherTriplePlays PitcherTriplePlays { get; set; }
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
        public WinPct WinPct { get; set; }
        public PitcherGroundOutToFlyOutRatio PitcherGroundOutToFlyOutRatio { get; set; }
        public PitcherOnBasePct PitcherOnBasePct { get; set; }
        public PitcherSluggingPct PitcherSluggingPct { get; set; }
        public PitcherOnBasePlusSluggingPct PitcherOnBasePlusSluggingPct { get; set; }
        public StrikeoutsPer9Innings StrikeoutsPer9Innings { get; set; }
        public WalksAllowedPer9Innings WalksAllowedPer9Innings { get; set; }
        public HitsAllowedPer9Innings HitsAllowedPer9Innings { get; set; }
        public StrikeoutsToWalksRatio StrikeoutsToWalksRatio { get; set; }
        public PitchesPerInning PitchesPerInning { get; set; }
        public PitcherAtBats PitcherAtBats { get; set; }
    }

    public class PlayerStatsEntry
    {
        public Player player { get; set; }
        public Team team { get; set; }
        public Stats stats { get; set; }
    }

    public class PlayerStats
    {
        public string lastUpdatedOn { get; set; }
        public List<PlayerStatsEntry> playerstatsentry { get; set; }
    }

    public class CumulativePlayerStats : IFeedRoot
    {
        public PlayerStats PlayerStats { get; set; }
    }
}