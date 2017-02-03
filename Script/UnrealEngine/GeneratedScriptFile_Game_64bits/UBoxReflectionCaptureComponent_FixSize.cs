#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBoxReflectionCaptureComponent
	{
		static readonly int BoxTransitionDistance__Offset;
		public float BoxTransitionDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BoxTransitionDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoxTransitionDistance__Offset, false);}
			
		}
		
		static readonly int PreviewInfluenceBox__Offset;
		public UBoxComponent PreviewInfluenceBox
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewInfluenceBox__Offset); if (v == IntPtr.Zero)return null; UBoxComponent retValue = new UBoxComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PreviewCaptureBox__Offset;
		public UBoxComponent PreviewCaptureBox
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewCaptureBox__Offset); if (v == IntPtr.Zero)return null; UBoxComponent retValue = new UBoxComponent(); retValue._this = v; return retValue; }
			
		}
		
		static UBoxReflectionCaptureComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BoxReflectionCaptureComponent");
			BoxTransitionDistance__Offset=GetPropertyOffset(NativeClassPtr,"BoxTransitionDistance");
			PreviewInfluenceBox__Offset=GetPropertyOffset(NativeClassPtr,"PreviewInfluenceBox");
			PreviewCaptureBox__Offset=GetPropertyOffset(NativeClassPtr,"PreviewCaptureBox");
			
		}
		
	}
	
}
#endif
#endif
