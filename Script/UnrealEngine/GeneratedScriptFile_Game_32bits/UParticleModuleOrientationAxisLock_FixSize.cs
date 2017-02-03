#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleOrientationAxisLock
	{
		static readonly int LockAxisFlags__Offset;
		public EParticleAxisLock LockAxisFlags
		{
			get{ CheckIsValid();return (EParticleAxisLock)Marshal.PtrToStructure(_this.Get()+LockAxisFlags__Offset, typeof(EParticleAxisLock));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LockAxisFlags__Offset, false);}
			
		}
		
		static UParticleModuleOrientationAxisLock()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleOrientationAxisLock");
			LockAxisFlags__Offset=GetPropertyOffset(NativeClassPtr,"LockAxisFlags");
			
		}
		
	}
	
}
#endif
#endif
