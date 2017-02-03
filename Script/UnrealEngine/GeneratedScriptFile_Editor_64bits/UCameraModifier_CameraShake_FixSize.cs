#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A UCameraModifier_CameraShake is a camera modifier that can apply a UCameraShake to
	/// the owning camera.
	/// </summary>
	public partial class UCameraModifier_CameraShake
	{
		static readonly int ActiveShakes__Offset;
		/// <summary>List of active CameraShake instances</summary>
		public TObjectArray<UCameraShake>  ActiveShakes
		{
					get{ CheckIsValid();return new TObjectArray<UCameraShake>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveShakes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveShakes__Offset, false);}
			
		}
		
		static readonly int SplitScreenShakeScale__Offset;
		/// <summary>Scaling factor applied to all camera shakes in when in splitscreen mode. Normally used to reduce shaking, since shakes feel more intense in a smaller viewport.</summary>
		public float SplitScreenShakeScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SplitScreenShakeScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplitScreenShakeScale__Offset, false);}
			
		}
		
		static UCameraModifier_CameraShake()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraModifier_CameraShake");
			ActiveShakes__Offset=GetPropertyOffset(NativeClassPtr,"ActiveShakes");
			SplitScreenShakeScale__Offset=GetPropertyOffset(NativeClassPtr,"SplitScreenShakeScale");
			
		}
		
	}
	
}
#endif
#endif
