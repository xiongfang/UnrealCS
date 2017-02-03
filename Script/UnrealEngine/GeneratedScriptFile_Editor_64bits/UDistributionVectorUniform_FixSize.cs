#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionVectorUniform
	{
		static readonly int Max__Offset;
		/// <summary>Upper end of FVector magnitude range.</summary>
		public FVector Max
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Max__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Max__Offset, false);}
			
		}
		
		static readonly int Min__Offset;
		/// <summary>Lower end of FVector magnitude range.</summary>
		public FVector Min
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Min__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Min__Offset, false);}
			
		}
		
		static readonly int bLockAxes__Offset;
		/// <summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
		public bool bLockAxes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockAxes__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int LockedAxes__Offset;
		public EDistributionVectorLockFlags LockedAxes
		{
			get{ CheckIsValid();return (EDistributionVectorLockFlags)Marshal.PtrToStructure(_this.Get()+LockedAxes__Offset, typeof(EDistributionVectorLockFlags));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LockedAxes__Offset, false);}
			
		}
		
		static readonly int MirrorFlags__Offset;
		public EDistributionVectorMirrorFlags MirrorFlags
		{
			get{ CheckIsValid();return (EDistributionVectorMirrorFlags)Marshal.PtrToStructure(_this.Get()+MirrorFlags__Offset, typeof(EDistributionVectorMirrorFlags));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MirrorFlags__Offset, false);}
			
		}
		
		static readonly int bUseExtremes__Offset;
		public bool bUseExtremes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseExtremes__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseExtremes__Offset, 1,0,1,1);}
			
		}
		
		static UDistributionVectorUniform()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DistributionVectorUniform");
			Max__Offset=GetPropertyOffset(NativeClassPtr,"Max");
			Min__Offset=GetPropertyOffset(NativeClassPtr,"Min");
			bLockAxes__Offset=GetPropertyOffset(NativeClassPtr,"bLockAxes");
			LockedAxes__Offset=GetPropertyOffset(NativeClassPtr,"LockedAxes");
			MirrorFlags__Offset=GetPropertyOffset(NativeClassPtr,"MirrorFlags");
			bUseExtremes__Offset=GetPropertyOffset(NativeClassPtr,"bUseExtremes");
			
		}
		
	}
	
}
#endif
#endif
