#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Handles game-specific networking management (cheat detection, bandwidth management, etc.).</summary>
	public partial class AGameNetworkManager
	{
		static readonly int AdjustedNetSpeed__Offset;
		/// <summary>Current adjusted net speed - Used for dynamically managing netspeed for listen servers</summary>
		public int AdjustedNetSpeed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+AdjustedNetSpeed__Offset, typeof(int));}
			
		}
		
		static readonly int LastNetSpeedUpdateTime__Offset;
		/// <summary>Last time netspeed was updated for server (by client entering or leaving)</summary>
		public float LastNetSpeedUpdateTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastNetSpeedUpdateTime__Offset, typeof(float));}
			
		}
		
		static readonly int TotalNetBandwidth__Offset;
		/// <summary>Total available bandwidth for listen server, split dynamically across net connections</summary>
		public int TotalNetBandwidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TotalNetBandwidth__Offset, typeof(int));}
			
		}
		
		static readonly int MinDynamicBandwidth__Offset;
		/// <summary>Minimum bandwidth dynamically set per connection</summary>
		public int MinDynamicBandwidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinDynamicBandwidth__Offset, typeof(int));}
			
		}
		
		static readonly int MaxDynamicBandwidth__Offset;
		/// <summary>Maximum bandwidth dynamically set per connection</summary>
		public int MaxDynamicBandwidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxDynamicBandwidth__Offset, typeof(int));}
			
		}
		
		static readonly int bIsStandbyCheckingEnabled__Offset;
		/// <summary>Used to determine if checking for standby cheats should occur</summary>
		public bool bIsStandbyCheckingEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsStandbyCheckingEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHasStandbyCheatTriggered__Offset;
		/// <summary>Used to determine whether we've already caught a cheat or not</summary>
		public bool bHasStandbyCheatTriggered
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasStandbyCheatTriggered__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int StandbyRxCheatTime__Offset;
		/// <summary>The amount of time without packets before triggering the cheat code</summary>
		public float StandbyRxCheatTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StandbyRxCheatTime__Offset, typeof(float));}
			
		}
		
		static readonly int StandbyTxCheatTime__Offset;
		/// <summary>The amount of time without packets before triggering the cheat code</summary>
		public float StandbyTxCheatTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StandbyTxCheatTime__Offset, typeof(float));}
			
		}
		
		static readonly int BadPingThreshold__Offset;
		/// <summary>The point we determine the server is either delaying packets or has bad upstream</summary>
		public int BadPingThreshold
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+BadPingThreshold__Offset, typeof(int));}
			
		}
		
		static readonly int PercentMissingForRxStandby__Offset;
		/// <summary>The percentage of clients missing RX data before triggering the standby code</summary>
		public float PercentMissingForRxStandby
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PercentMissingForRxStandby__Offset, typeof(float));}
			
		}
		
		static readonly int PercentMissingForTxStandby__Offset;
		/// <summary>The percentage of clients missing TX data before triggering the standby code</summary>
		public float PercentMissingForTxStandby
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PercentMissingForTxStandby__Offset, typeof(float));}
			
		}
		
		static readonly int PercentForBadPing__Offset;
		/// <summary>The percentage of clients with bad ping before triggering the standby code</summary>
		public float PercentForBadPing
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PercentForBadPing__Offset, typeof(float));}
			
		}
		
		static readonly int JoinInProgressStandbyWaitTime__Offset;
		/// <summary>The amount of time to wait before checking a connection for standby issues</summary>
		public float JoinInProgressStandbyWaitTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JoinInProgressStandbyWaitTime__Offset, typeof(float));}
			
		}
		
		static readonly int MoveRepSize__Offset;
		/// <summary>Average size of replicated move packet (ServerMove() packet size) from player</summary>
		public float MoveRepSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MoveRepSize__Offset, typeof(float));}
			
		}
		
		static readonly int MAXPOSITIONERRORSQUARED__Offset;
		/// <summary>MAXPOSITIONERRORSQUARED is the square of the max position error that is accepted (not corrected) in net play</summary>
		public float MAXPOSITIONERRORSQUARED
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MAXPOSITIONERRORSQUARED__Offset, typeof(float));}
			
		}
		
		static readonly int MAXNEARZEROVELOCITYSQUARED__Offset;
		/// <summary>MAXNEARZEROVELOCITYSQUARED is the square of the max velocity that is considered zero (not corrected) in net play</summary>
		public float MAXNEARZEROVELOCITYSQUARED
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MAXNEARZEROVELOCITYSQUARED__Offset, typeof(float));}
			
		}
		
		static readonly int CLIENTADJUSTUPDATECOST__Offset;
		/// <summary>
		/// CLIENTADJUSTUPDATECOST is the bandwidth cost in bytes of sending a client adjustment update. 180 is greater than the actual cost, but represents a tweaked value reserving enough bandwidth for
		///       other updates sent to the client.  Increase this value to reduce client adjustment update frequency, or if the amount of data sent in the clientadjustment() call increases
		/// </summary>
		public float CLIENTADJUSTUPDATECOST
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CLIENTADJUSTUPDATECOST__Offset, typeof(float));}
			
		}
		
		static readonly int MAXCLIENTUPDATEINTERVAL__Offset;
		/// <summary>MAXCLIENTUPDATEINTERVAL is the maximum time between movement updates from the client before the server forces an update.</summary>
		public float MAXCLIENTUPDATEINTERVAL
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MAXCLIENTUPDATEINTERVAL__Offset, typeof(float));}
			
		}
		
		static readonly int MaxMoveDeltaTime__Offset;
		/// <summary>MaxMoveDeltaTime is the default maximum time delta of CharacterMovement ServerMoves. Should be less than or equal to MAXCLIENTUPDATEINTERVAL, otherwise server will interfere by forceing position updates</summary>
		public float MaxMoveDeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxMoveDeltaTime__Offset, typeof(float));}
			
		}
		
		static readonly int ClientAuthorativePosition__Offset;
		/// <summary>If client update is within MAXPOSITIONERRORSQUARED then he is authorative on his final position</summary>
		public bool ClientAuthorativePosition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ClientAuthorativePosition__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ClientErrorUpdateRateLimit__Offset;
		/// <summary>Minimum delay between the server sending error corrections to a client, in seconds.</summary>
		public float ClientErrorUpdateRateLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ClientErrorUpdateRateLimit__Offset, typeof(float));}
			
		}
		
		static readonly int bMovementTimeDiscrepancyDetection__Offset;
		/// <summary>Whether movement time discrepancy detection is enabled.</summary>
		public bool bMovementTimeDiscrepancyDetection
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMovementTimeDiscrepancyDetection__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bMovementTimeDiscrepancyResolution__Offset;
		/// <summary>Whether movement time discrepancy resolution is enabled (when detected, make client movement "pay back" excessive time discrepancies)</summary>
		public bool bMovementTimeDiscrepancyResolution
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMovementTimeDiscrepancyResolution__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int MovementTimeDiscrepancyMaxTimeMargin__Offset;
		/// <summary>Maximum time client can be ahead before triggering movement time discrepancy detection/resolution (if enabled).</summary>
		public float MovementTimeDiscrepancyMaxTimeMargin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTimeDiscrepancyMaxTimeMargin__Offset, typeof(float));}
			
		}
		
		static readonly int MovementTimeDiscrepancyMinTimeMargin__Offset;
		/// <summary>Maximum time client can be behind.</summary>
		public float MovementTimeDiscrepancyMinTimeMargin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTimeDiscrepancyMinTimeMargin__Offset, typeof(float));}
			
		}
		
		static readonly int MovementTimeDiscrepancyResolutionRate__Offset;
		/// <summary>
		/// During time discrepancy resolution, we "pay back" the time discrepancy at this rate for future moves until total error is zero.
		/// 1.0 = 100% resolution rate, meaning the next X ServerMoves from the client are fully paying back the time,
		/// 0.5 = 50% resolution rate, meaning future ServerMoves will spend 50% of tick continuing to move the character and 50% paying back.
		/// Lowering from 100% could be used to produce less severe/noticeable corrections, although typically we would want to correct
		/// the client as quickly as possible.
		/// </summary>
		public float MovementTimeDiscrepancyResolutionRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTimeDiscrepancyResolutionRate__Offset, typeof(float));}
			
		}
		
		static readonly int MovementTimeDiscrepancyDriftAllowance__Offset;
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
		public float MovementTimeDiscrepancyDriftAllowance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTimeDiscrepancyDriftAllowance__Offset, typeof(float));}
			
		}
		
		static readonly int bMovementTimeDiscrepancyForceCorrectionsDuringResolution__Offset;
		/// <summary>
		/// Whether client moves should be force corrected during time discrepancy resolution, useful for projects that have lenient
		/// move error tolerance/ClientAuthorativePosition enabled.
		/// </summary>
		public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMovementTimeDiscrepancyForceCorrectionsDuringResolution__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bUseDistanceBasedRelevancy__Offset;
		/// <summary>If true, actor network relevancy is constrained by whether they are within their NetCullDistanceSquared from the client's view point.</summary>
		public bool bUseDistanceBasedRelevancy
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDistanceBasedRelevancy__Offset, 1, 0, 1, 255);}
			
		}
		
		static AGameNetworkManager()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameNetworkManager");
			AdjustedNetSpeed__Offset=GetPropertyOffset(NativeClassPtr,"AdjustedNetSpeed");
			LastNetSpeedUpdateTime__Offset=GetPropertyOffset(NativeClassPtr,"LastNetSpeedUpdateTime");
			TotalNetBandwidth__Offset=GetPropertyOffset(NativeClassPtr,"TotalNetBandwidth");
			MinDynamicBandwidth__Offset=GetPropertyOffset(NativeClassPtr,"MinDynamicBandwidth");
			MaxDynamicBandwidth__Offset=GetPropertyOffset(NativeClassPtr,"MaxDynamicBandwidth");
			bIsStandbyCheckingEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bIsStandbyCheckingEnabled");
			bHasStandbyCheatTriggered__Offset=GetPropertyOffset(NativeClassPtr,"bHasStandbyCheatTriggered");
			StandbyRxCheatTime__Offset=GetPropertyOffset(NativeClassPtr,"StandbyRxCheatTime");
			StandbyTxCheatTime__Offset=GetPropertyOffset(NativeClassPtr,"StandbyTxCheatTime");
			BadPingThreshold__Offset=GetPropertyOffset(NativeClassPtr,"BadPingThreshold");
			PercentMissingForRxStandby__Offset=GetPropertyOffset(NativeClassPtr,"PercentMissingForRxStandby");
			PercentMissingForTxStandby__Offset=GetPropertyOffset(NativeClassPtr,"PercentMissingForTxStandby");
			PercentForBadPing__Offset=GetPropertyOffset(NativeClassPtr,"PercentForBadPing");
			JoinInProgressStandbyWaitTime__Offset=GetPropertyOffset(NativeClassPtr,"JoinInProgressStandbyWaitTime");
			MoveRepSize__Offset=GetPropertyOffset(NativeClassPtr,"MoveRepSize");
			MAXPOSITIONERRORSQUARED__Offset=GetPropertyOffset(NativeClassPtr,"MAXPOSITIONERRORSQUARED");
			MAXNEARZEROVELOCITYSQUARED__Offset=GetPropertyOffset(NativeClassPtr,"MAXNEARZEROVELOCITYSQUARED");
			CLIENTADJUSTUPDATECOST__Offset=GetPropertyOffset(NativeClassPtr,"CLIENTADJUSTUPDATECOST");
			MAXCLIENTUPDATEINTERVAL__Offset=GetPropertyOffset(NativeClassPtr,"MAXCLIENTUPDATEINTERVAL");
			MaxMoveDeltaTime__Offset=GetPropertyOffset(NativeClassPtr,"MaxMoveDeltaTime");
			ClientAuthorativePosition__Offset=GetPropertyOffset(NativeClassPtr,"ClientAuthorativePosition");
			ClientErrorUpdateRateLimit__Offset=GetPropertyOffset(NativeClassPtr,"ClientErrorUpdateRateLimit");
			bMovementTimeDiscrepancyDetection__Offset=GetPropertyOffset(NativeClassPtr,"bMovementTimeDiscrepancyDetection");
			bMovementTimeDiscrepancyResolution__Offset=GetPropertyOffset(NativeClassPtr,"bMovementTimeDiscrepancyResolution");
			MovementTimeDiscrepancyMaxTimeMargin__Offset=GetPropertyOffset(NativeClassPtr,"MovementTimeDiscrepancyMaxTimeMargin");
			MovementTimeDiscrepancyMinTimeMargin__Offset=GetPropertyOffset(NativeClassPtr,"MovementTimeDiscrepancyMinTimeMargin");
			MovementTimeDiscrepancyResolutionRate__Offset=GetPropertyOffset(NativeClassPtr,"MovementTimeDiscrepancyResolutionRate");
			MovementTimeDiscrepancyDriftAllowance__Offset=GetPropertyOffset(NativeClassPtr,"MovementTimeDiscrepancyDriftAllowance");
			bMovementTimeDiscrepancyForceCorrectionsDuringResolution__Offset=GetPropertyOffset(NativeClassPtr,"bMovementTimeDiscrepancyForceCorrectionsDuringResolution");
			bUseDistanceBasedRelevancy__Offset=GetPropertyOffset(NativeClassPtr,"bUseDistanceBasedRelevancy");
			
		}
		
	}
	
}
#endif
#endif
