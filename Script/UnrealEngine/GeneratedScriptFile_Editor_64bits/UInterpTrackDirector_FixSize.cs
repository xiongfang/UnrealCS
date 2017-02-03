#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackDirector
	{
		static readonly int CutTrack__Offset;
		/// <summary>Array of cuts between cameras.</summary>
		public TStructArray<FDirectorTrackCut> CutTrack
		{
			get{ CheckIsValid();return new TStructArray<FDirectorTrackCut>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CutTrack__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CutTrack__Offset, false);}
			
		}
		
		static readonly int bSimulateCameraCutsOnClients__Offset;
		/// <summary>True to allow clients to simulate their own camera cuts.  Can help with latency-induced timing issues.</summary>
		public bool bSimulateCameraCutsOnClients
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSimulateCameraCutsOnClients__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSimulateCameraCutsOnClients__Offset, 1,0,1,1);}
			
		}
		
		static readonly int PreviewCamera__Offset;
		/// <summary>The camera actor which the track is currently focused on. Only valid if this track or it's group is selected</summary>
		public ACameraActor PreviewCamera
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewCamera__Offset); if (v == IntPtr.Zero)return null; ACameraActor retValue = new ACameraActor(); retValue._this = v; return retValue; }
			
		}
		
		static UInterpTrackDirector()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackDirector");
			CutTrack__Offset=GetPropertyOffset(NativeClassPtr,"CutTrack");
			bSimulateCameraCutsOnClients__Offset=GetPropertyOffset(NativeClassPtr,"bSimulateCameraCutsOnClients");
			PreviewCamera__Offset=GetPropertyOffset(NativeClassPtr,"PreviewCamera");
			
		}
		
	}
	
}
#endif
#endif
