#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackDirector
	{
		static readonly int CutTrack__Offset;
		public TStructArray<FDirectorTrackCut> CutTrack
		{
			get{ CheckIsValid();return new TStructArray<FDirectorTrackCut>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CutTrack__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CutTrack__Offset, false);}
			
		}
		
		static readonly int bSimulateCameraCutsOnClients__Offset;
		public bool bSimulateCameraCutsOnClients
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSimulateCameraCutsOnClients__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSimulateCameraCutsOnClients__Offset, 1,0,1,1);}
			
		}
		
		static UInterpTrackDirector()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackDirector");
			CutTrack__Offset=GetPropertyOffset(NativeClassPtr,"CutTrack");
			bSimulateCameraCutsOnClients__Offset=GetPropertyOffset(NativeClassPtr,"bSimulateCameraCutsOnClients");
			
		}
		
	}
	
}
#endif
#endif
