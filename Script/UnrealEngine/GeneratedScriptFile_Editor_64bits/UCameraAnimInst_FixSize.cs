#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCameraAnimInst
	{
		static readonly int CamAnim__Offset;
		/// <summary>which CameraAnim this is an instance of</summary>
		public UCameraAnim CamAnim
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CamAnim__Offset); if (v == IntPtr.Zero)return null; UCameraAnim retValue = new UCameraAnim(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InterpGroupInst__Offset;
		public UInterpGroupInst InterpGroupInst
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InterpGroupInst__Offset); if (v == IntPtr.Zero)return null; UInterpGroupInst retValue = new UInterpGroupInst(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayRate__Offset;
		/// <summary>Multiplier for playback rate.  1.0 = normal.</summary>
		public float PlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayRate__Offset, typeof(float));}
			
		}
		
		static readonly int MoveTrack__Offset;
		/// <summary>cached movement track from the currently playing anim so we don't have to go find it every frame</summary>
		public UInterpTrackMove MoveTrack
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MoveTrack__Offset); if (v == IntPtr.Zero)return null; UInterpTrackMove retValue = new UInterpTrackMove(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MoveInst__Offset;
		public UInterpTrackInstMove MoveInst
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MoveInst__Offset); if (v == IntPtr.Zero)return null; UInterpTrackInstMove retValue = new UInterpTrackInstMove(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlaySpace__Offset;
		public ECameraAnimPlaySpace PlaySpace
		{
			get{ CheckIsValid();return (ECameraAnimPlaySpace)Marshal.PtrToStructure(_this.Get()+PlaySpace__Offset, typeof(ECameraAnimPlaySpace));}
			
		}
		
		static UCameraAnimInst()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraAnimInst");
			CamAnim__Offset=GetPropertyOffset(NativeClassPtr,"CamAnim");
			InterpGroupInst__Offset=GetPropertyOffset(NativeClassPtr,"InterpGroupInst");
			PlayRate__Offset=GetPropertyOffset(NativeClassPtr,"PlayRate");
			MoveTrack__Offset=GetPropertyOffset(NativeClassPtr,"MoveTrack");
			MoveInst__Offset=GetPropertyOffset(NativeClassPtr,"MoveInst");
			PlaySpace__Offset=GetPropertyOffset(NativeClassPtr,"PlaySpace");
			
		}
		
	}
	
}
#endif
#endif
