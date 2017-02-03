#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleOrientationAxisLock
	{
		static readonly int LockAxisFlags__Offset;
		/// <summary>
		/// The lock axis flag setting.
		/// Can be one of the following:
		///         EPAL_NONE                       No locking to an axis.
		///         EPAL_X                          Lock the sprite facing towards +X.
		///         EPAL_Y                          Lock the sprite facing towards +Y.
		///         EPAL_Z                          Lock the sprite facing towards +Z.
		///         EPAL_NEGATIVE_X         Lock the sprite facing towards -X.
		///         EPAL_NEGATIVE_Y         Lock the sprite facing towards -Y.
		///         EPAL_NEGATIVE_Z         Lock the sprite facing towards -Z.
		///         EPAL_ROTATE_X           Lock the sprite rotation on the X-axis.
		///         EPAL_ROTATE_Y           Lock the sprite rotation on the Y-axis.
		///         EPAL_ROTATE_Z           Lock the sprite rotation on the Z-axis.
		/// </summary>
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
