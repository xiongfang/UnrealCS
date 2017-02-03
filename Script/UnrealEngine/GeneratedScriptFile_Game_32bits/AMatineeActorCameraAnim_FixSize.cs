#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AMatineeActorCameraAnim
	{
		static readonly int CameraAnim__Offset;
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
