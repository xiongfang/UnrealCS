using System;
namespace UnrealEngine
{
	public partial class AGameNetworkManager:AInfo
	{
		/// <summary>Current adjusted net speed - Used for dynamically managing netspeed for listen servers</summary>
		public int AdjustedNetSpeed;
		
		/// <summary>Last time netspeed was updated for server (by client entering or leaving)</summary>
		public float LastNetSpeedUpdateTime;
		
		/// <summary>Total available bandwidth for listen server, split dynamically across net connections</summary>
		public int TotalNetBandwidth;
		
		/// <summary>Minimum bandwidth dynamically set per connection</summary>
		public int MinDynamicBandwidth;
		
		/// <summary>Maximum bandwidth dynamically set per connection</summary>
		public int MaxDynamicBandwidth;
		
		/// <summary>Used to determine if checking for standby cheats should occur</summary>
		public bool bIsStandbyCheckingEnabled;
		
		/// <summary>Used to determine whether we've already caught a cheat or not</summary>
		public bool bHasStandbyCheatTriggered;
		
		/// <summary>The amount of time without packets before triggering the cheat code</summary>
		public float StandbyRxCheatTime;
		
		/// <summary>The amount of time without packets before triggering the cheat code</summary>
		public float StandbyTxCheatTime;
		
		/// <summary>The point we determine the server is either delaying packets or has bad upstream</summary>
		public int BadPingThreshold;
		
		/// <summary>The percentage of clients missing RX data before triggering the standby code</summary>
		public float PercentMissingForRxStandby;
		
		/// <summary>The percentage of clients missing TX data before triggering the standby code</summary>
		public float PercentMissingForTxStandby;
		
		/// <summary>The percentage of clients with bad ping before triggering the standby code</summary>
		public float PercentForBadPing;
		
		/// <summary>The amount of time to wait before checking a connection for standby issues</summary>
		public float JoinInProgressStandbyWaitTime;
		
		/// <summary>Average size of replicated move packet (ServerMove() packet size) from player</summary>
		public float MoveRepSize;
		
		/// <summary>MAXPOSITIONERRORSQUARED is the square of the max position error that is accepted (not corrected) in net play</summary>
		public float MAXPOSITIONERRORSQUARED;
		
		/// <summary>MAXNEARZEROVELOCITYSQUARED is the square of the max velocity that is considered zero (not corrected) in net play</summary>
		public float MAXNEARZEROVELOCITYSQUARED;
		
		/// <summary>
		/// CLIENTADJUSTUPDATECOST is the bandwidth cost in bytes of sending a client adjustment update. 180 is greater than the actual cost, but represents a tweaked value reserving enough bandwidth for
		///       other updates sent to the client.  Increase this value to reduce client adjustment update frequency, or if the amount of data sent in the clientadjustment() call increases
		/// </summary>
		public float CLIENTADJUSTUPDATECOST;
		
		/// <summary>MAXCLIENTUPDATEINTERVAL is the maximum time between movement updates from the client before the server forces an update.</summary>
		public float MAXCLIENTUPDATEINTERVAL;
		
		/// <summary>MaxMoveDeltaTime is the default maximum time delta of CharacterMovement ServerMoves. Should be less than or equal to MAXCLIENTUPDATEINTERVAL, otherwise server will interfere by forceing position updates</summary>
		public float MaxMoveDeltaTime;
		
		/// <summary>If client update is within MAXPOSITIONERRORSQUARED then he is authorative on his final position</summary>
		public bool ClientAuthorativePosition;
		
		/// <summary>Minimum delay between the server sending error corrections to a client, in seconds.</summary>
		public float ClientErrorUpdateRateLimit;
		
		/// <summary>Whether movement time discrepancy detection is enabled.</summary>
		public bool bMovementTimeDiscrepancyDetection;
		
		/// <summary>Whether movement time discrepancy resolution is enabled (when detected, make client movement "pay back" excessive time discrepancies)</summary>
		public bool bMovementTimeDiscrepancyResolution;
		
		/// <summary>Maximum time client can be ahead before triggering movement time discrepancy detection/resolution (if enabled).</summary>
		public float MovementTimeDiscrepancyMaxTimeMargin;
		
		/// <summary>Maximum time client can be behind.</summary>
		public float MovementTimeDiscrepancyMinTimeMargin;
		
		/// <summary>
		/// During time discrepancy resolution, we "pay back" the time discrepancy at this rate for future moves until total error is zero.
		/// 1.0 = 100% resolution rate, meaning the next X ServerMoves from the client are fully paying back the time,
		/// 0.5 = 50% resolution rate, meaning future ServerMoves will spend 50% of tick continuing to move the character and 50% paying back.
		/// Lowering from 100% could be used to produce less severe/noticeable corrections, although typically we would want to correct
		/// the client as quickly as possible.
		/// </summary>
		public float MovementTimeDiscrepancyResolutionRate;
		
		/// <summary>
		/// Accepted drift in clocks between client and server as a percent per second allowed.
		/// 0.0 is "no forgiveness" and all logic would run on raw values, no tampering on the server side.
		/// 0.02 would be a 2% per second difference "forgiven" - if the time discrepancy in a given second was less than 2%,
		/// the error handling/detection code effectively ignores it.
		/// Increasing this value above 0% lessens the chance of false positives on time discrepancy (burst packet loss, performance
		/// hitches), but also means anyone tampering with their client time below that percent will not be detected and no resolution
		/// action will be taken, and anyone above that threshold will still gain the advantage of this % of time boost (if running at
		/// 10% speed-up and this value is 0.05 or 5% allowance, they would only be resolved down to a 5% speed boost).
		/// Time discrepancy detection code DOES keep track of LifetimeRawTimeDiscrepancy, which is unaffected by this drift allowance,
		/// so cheating below DriftAllowance percent could be tracked and acted on outside of an individual game. For example, if DriftAllowance
		/// was 0.05 (meaning we're not going to actively prevent any cheating below 5% boosts to ensure less false positives for normal players),
		/// we could still post-process analytics of the game showing that Player X regularly runs at 4% speed boost and take action.
		/// </summary>
		public float MovementTimeDiscrepancyDriftAllowance;
		
		/// <summary>
		/// Whether client moves should be force corrected during time discrepancy resolution, useful for projects that have lenient
		/// move error tolerance/ClientAuthorativePosition enabled.
		/// </summary>
		public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution;
		
		/// <summary>If true, actor network relevancy is constrained by whether they are within their NetCullDistanceSquared from the client's view point.</summary>
		public bool bUseDistanceBasedRelevancy;
		
		
	}
	
}
