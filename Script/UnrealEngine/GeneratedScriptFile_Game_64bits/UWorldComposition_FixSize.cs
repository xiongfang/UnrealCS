#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWorldComposition
	{
		static readonly int TilesStreaming__Offset;
		public TObjectArray<ULevelStreaming>  TilesStreaming
		{
					get{ CheckIsValid();return new TObjectArray<ULevelStreaming>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TilesStreaming__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TilesStreaming__Offset, false);}
			
		}
		
		static readonly int TilesStreamingTimeThreshold__Offset;
		public double TilesStreamingTimeThreshold
		{
			get{ CheckIsValid();return (double)Marshal.PtrToStructure(_this.Get()+TilesStreamingTimeThreshold__Offset, typeof(double));}
			
		}
		
		static readonly int bLoadAllTilesDuringCinematic__Offset;
		public bool bLoadAllTilesDuringCinematic
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoadAllTilesDuringCinematic__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bRebaseOriginIn3DSpace__Offset;
		public bool bRebaseOriginIn3DSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRebaseOriginIn3DSpace__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int RebaseOriginDistance__Offset;
		public float RebaseOriginDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RebaseOriginDistance__Offset, typeof(float));}
			
		}
		
		static UWorldComposition()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WorldComposition");
			TilesStreaming__Offset=GetPropertyOffset(NativeClassPtr,"TilesStreaming");
			TilesStreamingTimeThreshold__Offset=GetPropertyOffset(NativeClassPtr,"TilesStreamingTimeThreshold");
			bLoadAllTilesDuringCinematic__Offset=GetPropertyOffset(NativeClassPtr,"bLoadAllTilesDuringCinematic");
			bRebaseOriginIn3DSpace__Offset=GetPropertyOffset(NativeClassPtr,"bRebaseOriginIn3DSpace");
			RebaseOriginDistance__Offset=GetPropertyOffset(NativeClassPtr,"RebaseOriginDistance");
			
		}
		
	}
	
}
#endif
#endif
