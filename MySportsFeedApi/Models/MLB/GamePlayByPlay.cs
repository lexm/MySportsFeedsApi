using System.Collections.Generic;

namespace MySportsFeedsApi.Models.MLB
{
    public class BattingTeam
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

    public class BattingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string JerseyNumber { get; set; }
    }

    public class BatterUp
    {
        public BattingPlayer battingPlayer { get; set; }
        public string standingLeftOrRight { get; set; }
        public string result { get; set; }
    }

    public class BattingPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string JerseyNumber { get; set; }
    }

    public class PitchingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class Pitch
    {
        public BattingPlayer2 battingPlayer { get; set; }
        public PitchingPlayer pitchingPlayer { get; set; }
        public string throwingLeftOrRight { get; set; }
        public string result { get; set; }
        public string ballStartSpeed { get; set; }
        public string ballEndSpeed { get; set; }
        public string pitchedLocationX { get; set; }
        public string pitchedLocationY { get; set; }
    }

    public class BattingPlayer3
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string JerseyNumber { get; set; }
    }

    public class PitchingPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class RetrievedByPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class Hit
    {
        public BattingPlayer3 battingPlayer { get; set; }
        public PitchingPlayer2 pitchingPlayer { get; set; }
        public string hitType { get; set; }
        public string isOut { get; set; }
        public string isCaughtOut { get; set; }
        public string isError { get; set; }
        public RetrievedByPlayer retrievedByPlayer { get; set; }
        public string retrievedAtLocationX { get; set; }
        public string retrievedAtLocationY { get; set; }
    }

    public class RunningPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string JerseyNumber { get; set; }
    }

    public class BaseRunAttempt
    {
        public RunningPlayer runningPlayer { get; set; }
        public string fromBase { get; set; }
        public string toBase { get; set; }
        public string isSafe { get; set; }
        public string isRunScored { get; set; }
        public string isForcedOut { get; set; }
        public string isWalk { get; set; }
        public string isWalkIntentional { get; set; }
        public string isPassedBall { get; set; }
        public string isWildPitch { get; set; }
        public string isEarnedRun { get; set; }
    }

    public class FromPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class ToPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class RunningPlayer2
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class BallThrow
    {
        public FromPlayer fromPlayer { get; set; }
        public ToPlayer toPlayer { get; set; }
        public RunningPlayer2 runningPlayer { get; set; }
        public string fromBase { get; set; }
        public string toBase { get; set; }
        public string isCaught { get; set; }
        public string isRunningPlayerOut { get; set; }
        public string isTagOut { get; set; }
        public string isForceOut { get; set; }
        public string isThrowingError { get; set; }
        public string isCatchingError { get; set; }
    }

    public class PitchingPlayer3
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class RunningPlayer3
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string JerseyNumber { get; set; }
    }

    public class CatchingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class PickoffAttempt
    {
        public PitchingPlayer3 pitchingPlayer { get; set; }
        public RunningPlayer3 runningPlayer { get; set; }
        public CatchingPlayer catchingPlayer { get; set; }
        public string toBase { get; set; }
        public string isSuccessful { get; set; }
    }

    public class OutgoingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class IncomingPlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }

    public class PlayerSubstitution
    {
        public Team team { get; set; }
        public string position { get; set; }
        public OutgoingPlayer outgoingPlayer { get; set; }
        public IncomingPlayer incomingPlayer { get; set; }
    }

    public class AtBatPlay
    {
        public BatterUp batterUp { get; set; }
        public Pitch pitch { get; set; }
        public Hit hit { get; set; }
        public BaseRunAttempt baseRunAttempt { get; set; }
        public BallThrow ballThrow { get; set; }
        public PickoffAttempt pickoffAttempt { get; set; }
        public PlayerSubstitution playerSubstitution { get; set; }
    }

    public class AtBat
    {
        public string inning { get; set; }
        public string inningHalf { get; set; }
        public BattingTeam battingTeam { get; set; }
        public List<AtBatPlay> atBatPlay { get; set; }
    }

    public class LiveAtBats
    {
        public List<AtBat> atBat { get; set; }
    }

    public class PlayByPlay
    {
        public string lastUpdatedOn { get; set; }
        public Game game { get; set; }
        public LiveAtBats atBats { get; set; }
    }

    public class GamePlayByPlay : IFeedRoot
    {
        public PlayByPlay gameplaybyplay { get; set; }
    }
}