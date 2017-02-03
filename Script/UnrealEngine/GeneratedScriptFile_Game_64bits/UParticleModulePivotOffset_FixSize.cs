#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModulePivotOffset
	{
		static readonly int PivotOffset__Offset;
		public FVector2D PivotOffset
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+PivotOffset__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PivotOffset__Offset, false);}
			
		}
		
		static UParticleModulePivotOffset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModulePivotOffset");
			PivotOffset__Offset=GetPropertyOffset(NativeClassPtr,"PivotOffset");
			
		}
		
	}
	
}
#endif
#endif
