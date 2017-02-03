#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Actor used to capture the scene for reflection in a sphere shape.
	/// @see https://docs.unrealengine.com/latest/INT/Resources/ContentExamples/Reflections/1_4
	/// </summary>
	public partial class ASphereReflectionCapture
	{
		static readonly int DrawCaptureRadius__Offset;
		public UDrawSphereComponent DrawCaptureRadius
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DrawCaptureRadius__Offset); if (v == IntPtr.Zero)return null; UDrawSphereComponent retValue = new UDrawSphereComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ASphereReflectionCapture()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SphereReflectionCapture");
			DrawCaptureRadius__Offset=GetPropertyOffset(NativeClassPtr,"DrawCaptureRadius");
			
		}
		
	}
	
}
#endif
#endif
