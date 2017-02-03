#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCameraAnimInst
	{
		static readonly int CamAnim__Offset;
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
		public float PlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayRate__Offset, typeof(float));}
			
		}
		
		static readonly int MoveTrack__Offset;
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
