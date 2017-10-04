using System;
namespace UnrealEngine
{
	public partial class UParticleModuleOrientationAxisLock:UParticleModuleOrientationBase
	{
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
		public EParticleAxisLock LockAxisFlags;
		
		
	}
	
}
