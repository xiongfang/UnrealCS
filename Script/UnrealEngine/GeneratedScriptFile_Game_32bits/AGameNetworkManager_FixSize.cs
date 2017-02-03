#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AGameNetworkManager
	{
		static readonly int AdjustedNetSpeed__Offset;
		public int AdjustedNetSpeed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+AdjustedNetSpeed__Offset, typeof(int));}
			
		}
		
		static readonly int LastNetSpeedUpdateTime__Offset;
		public float LastNetSpeedUpdateTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastNetSpeedUpdateTime__Offset, typeof(float));}
			
		}
		
		static readonly int TotalNetBandwidth__Offset;
		public int TotalNetBandwidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TotalNetBandwidth__Offset, typeof(int));}
			
		}
		
		static readonly int MinDynamicBandwidth__Offset;
		public int MinDynamicBandwidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinDynamicBandwidth__Offset, typeof(int));}
			
		}
		
		static readonly int MaxDynamicBandwidth__Offset;
		public int MaxDynamicBandwidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxDynamicBandwidth__Offset, typeof(int));}
			
		}
		
		static readonly int bIsStandbyCheckingEnabled__Offset;
		public bool bIsStandbyCheckingEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsStandbyCheckingEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHasStandbyCheatTriggered__Offset;
		public bool bHasStandbyCheatTriggered
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasStandbyCheatTriggered__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int StandbyRxCheatTime__Offset;
		public float StandbyRxCheatTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StandbyRxCheatTime__Offset, typeof(float));}
			
		}
		
		static readonly int StandbyTxCheatTime__Offset;
		public float StandbyTxCheatTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StandbyTxCheatTime__Offset, typeof(float));}
			
		}
		
		static readonly int BadPingThreshold__Offset;
		public int BadPingThreshold
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+BadPingThreshold__Offset, typeof(int));}
			
		}
		
		static readonly int PercentMissingForRxStandby__Offset;
		public float PercentMissingForRxStandby
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PercentMissingForRxStandby__Offset, typeof(float));}
			
		}
		
		static readonly int PercentMissingForTxStandby__Offset;
		public float PercentMissingForTxStandby
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PercentMissingForTxStandby__Offset, typeof(float));}
			
		}
		
		static readonly int PercentForBadPing__Offset;
		public float PercentForBadPing
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PercentForBadPing__Offset, typeof(float));}
			
		}
		
		static readonly int JoinInProgressStandbyWaitTime__Offset;
		public float JoinInProgressStandbyWaitTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JoinInProgressStandbyWaitTime__Offset, typeof(float));}
			
		}
		
		static readonly int MoveRepSize__Offset;
		public float MoveRepSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MoveRepSize__Offset, typeof(float));}
			
		}
		
		static readonly int MAXPOSITIONERRORSQUARED__Offset;
		public float MAXPOSITIONERRORSQUARED
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MAXPOSITIONERRORSQUARED__Offset, typeof(float));}
			
		}
		
		static readonly int MAXNEARZEROVELOCITYSQUARED__Offset;
		public float MAXNEARZEROVELOCITYSQUARED
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MAXNEARZEROVELOCITYSQUARED__Offset, typeof(float));}
			
		}
		
		static readonly int CLIENTADJUSTUPDATECOST__Offset;
		public float CLIENTADJUSTUPDATECOST
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CLIENTADJUSTUPDATECOST__Offset, typeof(float));}
			
		}
		
		static readonly int MAXCLIENTUPDATEINTERVAL__Offset;
		public float MAXCLIENTUPDATEINTERVAL
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MAXCLIENTUPDATEINTERVAL__Offset, typeof(float));}
			
		}
		
		static readonly int MaxMoveDeltaTime__Offset;
		public float MaxMoveDeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxMoveDeltaTime__Offset, typeof(float));}
			
		}
		
		static readonly int ClientAuthorativePosition__Offset;
		public bool ClientAuthorativePosition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ClientAuthorativePosition__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ClientErrorUpdateRateLimit__Offset;
		public float ClientErrorUpdateRateLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ClientErrorUpdateRateLimit__Offset, typeof(float));}
			
		}
		
		static readonly int bMovementTimeDiscrepancyDetection__Offset;
		public bool bMovementTimeDiscrepancyDetection
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMovementTimeDiscrepancyDetection__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bMovementTimeDiscrepancyResolution__Offset;
		public bool bMovementTimeDiscrepancyResolution
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMovementTimeDiscrepancyResolution__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int MovementTimeDiscrepancyMaxTimeMargin__Offset;
		public float MovementTimeDiscrepancyMaxTimeMargin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTimeDiscrepancyMaxTimeMargin__Offset, typeof(float));}
			
		}
		
		static readonly int MovementTimeDiscrepancyMinTimeMargin__Offset;
		public float MovementTimeDiscrepancyMinTimeMargin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTimeDiscrepancyMinTimeMargin__Offset, typeof(float));}
			
		}
		
		static readonly int MovementTimeDiscrepancyResolutionRate__Offset;
		public float MovementTimeDiscrepancyResolutionRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTimeDiscrepancyResolutionRate__Offset, typeof(float));}
			
		}
		
		static readonly int MovementTimeDiscrepancyDriftAllowance__Offset;
		public float MovementTimeDiscrepancyDriftAllowance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTimeDiscrepancyDriftAllowance__Offset, typeof(float));}
			
		}
		
		static readonly int bMovementTimeDiscrepancyForceCorrectionsDuringResolution__Offset;
		public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMovementTimeDiscrepancyForceCorrectionsDuringResolution__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bUseDistanceBasedRelevancy__Offset;
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
