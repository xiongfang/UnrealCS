#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAvoidanceManager
	{
		static readonly int DefaultTimeToLive__Offset;
		/// <summary>How long an avoidance UID must not be updated before the system will put it back in the pool. Actual delay is up to 150% of this value.</summary>
		public float DefaultTimeToLive
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultTimeToLive__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultTimeToLive__Offset, false);}
			
		}
		
		static readonly int LockTimeAfterAvoid__Offset;
		/// <summary>How long to stay on course (barring collision) after making an avoidance move</summary>
		public float LockTimeAfterAvoid
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LockTimeAfterAvoid__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LockTimeAfterAvoid__Offset, false);}
			
		}
		
		static readonly int LockTimeAfterClean__Offset;
		/// <summary>How long to stay on course (barring collision) after making an unobstructed move (should be > 0.0, but can be less than a full frame)</summary>
		public float LockTimeAfterClean
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LockTimeAfterClean__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LockTimeAfterClean__Offset, false);}
			
		}
		
		static readonly int DeltaTimeToPredict__Offset;
		/// <summary>This is how far forward in time (seconds) we extend our velocity cones and thus our prediction</summary>
		public float DeltaTimeToPredict
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DeltaTimeToPredict__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DeltaTimeToPredict__Offset, false);}
			
		}
		
		static readonly int ArtificialRadiusExpansion__Offset;
		/// <summary>Multiply the radius of all STORED avoidance objects by this value to allow a little extra room for avoidance maneuvers.</summary>
		public float ArtificialRadiusExpansion
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ArtificialRadiusExpansion__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ArtificialRadiusExpansion__Offset, false);}
			
		}
		
		static readonly int TestHeightDifference__Offset;
		/// <summary>Deprecated - use HeightCheckMargin, generally a much smaller value.</summary>
		public float TestHeightDifference
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TestHeightDifference__Offset, typeof(float));}
			
		}
		
		static readonly int HeightCheckMargin__Offset;
		/// <summary>Allowable height margin between obstacles and agents. This is over and above the difference in agent heights.</summary>
		public float HeightCheckMargin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HeightCheckMargin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HeightCheckMargin__Offset, false);}
			
		}
		
		static UAvoidanceManager()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AvoidanceManager");
			DefaultTimeToLive__Offset=GetPropertyOffset(NativeClassPtr,"DefaultTimeToLive");
			LockTimeAfterAvoid__Offset=GetPropertyOffset(NativeClassPtr,"LockTimeAfterAvoid");
			LockTimeAfterClean__Offset=GetPropertyOffset(NativeClassPtr,"LockTimeAfterClean");
			DeltaTimeToPredict__Offset=GetPropertyOffset(NativeClassPtr,"DeltaTimeToPredict");
			ArtificialRadiusExpansion__Offset=GetPropertyOffset(NativeClassPtr,"ArtificialRadiusExpansion");
			TestHeightDifference__Offset=GetPropertyOffset(NativeClassPtr,"TestHeightDifference");
			HeightCheckMargin__Offset=GetPropertyOffset(NativeClassPtr,"HeightCheckMargin");
			
		}
		
	}
	
}
#endif
#endif
