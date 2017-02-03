#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimComposite
	{
		static readonly int AnimationTrack__Offset;
		/// <summary>Serializable data that stores section/anim pairing *</summary>
		public FAnimTrack AnimationTrack
		{
			get{ CheckIsValid();return (FAnimTrack)Marshal.PtrToStructure(_this.Get()+AnimationTrack__Offset, typeof(FAnimTrack));}
			
		}
		
		static readonly int PreviewBasePose__Offset;
		/// <summary>Preview Base pose for additive BlendSpace *</summary>
		public UAnimSequence PreviewBasePose
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewBasePose__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PreviewBasePose__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PreviewBasePose__Offset, value._this.Get()); }
			
		}
		
		static UAnimComposite()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimComposite");
			AnimationTrack__Offset=GetPropertyOffset(NativeClassPtr,"AnimationTrack");
			PreviewBasePose__Offset=GetPropertyOffset(NativeClassPtr,"PreviewBasePose");
			
		}
		
	}
	
}
#endif
#endif
