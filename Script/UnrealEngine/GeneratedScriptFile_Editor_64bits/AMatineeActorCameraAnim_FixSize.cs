#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Actor used to control temporary matinees for camera anims that only exist in the editor</summary>
	public partial class AMatineeActorCameraAnim
	{
		static readonly int CameraAnim__Offset;
		/// <summary>The camera anim we are editing</summary>
		public UCameraAnim CameraAnim
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraAnim__Offset); if (v == IntPtr.Zero)return null; UCameraAnim retValue = new UCameraAnim(); retValue._this = v; return retValue; }
			
		}
		
		static AMatineeActorCameraAnim()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MatineeActorCameraAnim");
			CameraAnim__Offset=GetPropertyOffset(NativeClassPtr,"CameraAnim");
			
		}
		
	}
	
}
#endif
#endif
