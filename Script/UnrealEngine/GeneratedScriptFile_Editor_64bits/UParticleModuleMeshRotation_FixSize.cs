#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleMeshRotation
	{
		static readonly int StartRotation__Offset;
		/// <summary>
		/// Initial rotation in ROTATIONS PER SECOND (1 = 360 degrees).
		/// The value is retrieved using the EmitterTime.
		/// </summary>
		public FRawDistributionVector StartRotation
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartRotation__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartRotation__Offset, false);}
			
		}
		
		static readonly int bInheritParent__Offset;
		/// <summary>If true, apply the parents rotation as well.</summary>
		public bool bInheritParent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritParent__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritParent__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleMeshRotation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleMeshRotation");
			StartRotation__Offset=GetPropertyOffset(NativeClassPtr,"StartRotation");
			bInheritParent__Offset=GetPropertyOffset(NativeClassPtr,"bInheritParent");
			
		}
		
	}
	
}
#endif
#endif
