#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModulePivotOffset
	{
		static readonly int PivotOffset__Offset;
		/// <summary>Offset applied in UV space to the particle vertex positions. Defaults to (0.5,0.5) putting the pivot in the centre of the partilce.</summary>
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
