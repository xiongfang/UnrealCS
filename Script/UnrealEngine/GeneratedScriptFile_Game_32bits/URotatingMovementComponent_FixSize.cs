#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class URotatingMovementComponent
	{
		static readonly int RotationRate__Offset;
		public FRotator RotationRate
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RotationRate__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationRate__Offset, false);}
			
		}
		
		static readonly int PivotTranslation__Offset;
		public FVector PivotTranslation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PivotTranslation__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PivotTranslation__Offset, false);}
			
		}
		
		static readonly int bRotationInLocalSpace__Offset;
		public bool bRotationInLocalSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRotationInLocalSpace__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRotationInLocalSpace__Offset, 1,0,1,1);}
			
		}
		
		static URotatingMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RotatingMovementComponent");
			RotationRate__Offset=GetPropertyOffset(NativeClassPtr,"RotationRate");
			PivotTranslation__Offset=GetPropertyOffset(NativeClassPtr,"PivotTranslation");
			bRotationInLocalSpace__Offset=GetPropertyOffset(NativeClassPtr,"bRotationInLocalSpace");
			
		}
		
	}
	
}
#endif
#endif
