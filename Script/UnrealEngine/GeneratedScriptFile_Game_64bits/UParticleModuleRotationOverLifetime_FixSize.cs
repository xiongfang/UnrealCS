#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleRotationOverLifetime
	{
		static readonly int RotationOverLife__Offset;
		public FRawDistributionFloat RotationOverLife
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+RotationOverLife__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationOverLife__Offset, false);}
			
		}
		
		static readonly int Scale__Offset;
		public bool Scale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Scale__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Scale__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleRotationOverLifetime()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleRotationOverLifetime");
			RotationOverLife__Offset=GetPropertyOffset(NativeClassPtr,"RotationOverLife");
			Scale__Offset=GetPropertyOffset(NativeClassPtr,"Scale");
			
		}
		
	}
	
}
#endif
#endif
