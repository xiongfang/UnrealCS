#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAvoidanceManager
	{
		static readonly int DefaultTimeToLive__Offset;
		public float DefaultTimeToLive
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultTimeToLive__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultTimeToLive__Offset, false);}
			
		}
		
		static readonly int LockTimeAfterAvoid__Offset;
		public float LockTimeAfterAvoid
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LockTimeAfterAvoid__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LockTimeAfterAvoid__Offset, false);}
			
		}
		
		static readonly int LockTimeAfterClean__Offset;
		public float LockTimeAfterClean
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LockTimeAfterClean__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LockTimeAfterClean__Offset, false);}
			
		}
		
		static readonly int DeltaTimeToPredict__Offset;
		public float DeltaTimeToPredict
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DeltaTimeToPredict__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DeltaTimeToPredict__Offset, false);}
			
		}
		
		static readonly int ArtificialRadiusExpansion__Offset;
		public float ArtificialRadiusExpansion
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ArtificialRadiusExpansion__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ArtificialRadiusExpansion__Offset, false);}
			
		}
		
		static readonly int TestHeightDifference__Offset;
		public float TestHeightDifference
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TestHeightDifference__Offset, typeof(float));}
			
		}
		
		static readonly int HeightCheckMargin__Offset;
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
