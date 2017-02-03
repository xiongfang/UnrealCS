#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// WorldComposition represents world structure:
	///     - Holds list of all level packages participating in this world and theirs base parameters (bounding boxes, offset from origin)
	///     - Holds list of streaming level objects to stream in and out based on distance from current view point
	///  - Handles properly levels repositioning during level loading and saving
	/// </summary>
	public partial class UWorldComposition
	{
		static readonly int TilesStreaming__Offset;
		/// <summary>Streaming level objects for each tile</summary>
		public TObjectArray<ULevelStreaming>  TilesStreaming
		{
					get{ CheckIsValid();return new TObjectArray<ULevelStreaming>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TilesStreaming__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TilesStreaming__Offset, false);}
			
		}
		
		static readonly int TilesStreamingTimeThreshold__Offset;
		/// <summary>Time threshold between tile streaming state changes</summary>
		public double TilesStreamingTimeThreshold
		{
			get{ CheckIsValid();return (double)Marshal.PtrToStructure(_this.Get()+TilesStreamingTimeThreshold__Offset, typeof(double));}
			
		}
		
		static readonly int bLoadAllTilesDuringCinematic__Offset;
		/// <summary>Whether all distance dependent tiles should be loaded and visible during cinematic</summary>
		public bool bLoadAllTilesDuringCinematic
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoadAllTilesDuringCinematic__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bRebaseOriginIn3DSpace__Offset;
		/// <summary>Whether to rebase origin in 3D space, otherwise only on XY plane</summary>
		public bool bRebaseOriginIn3DSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRebaseOriginIn3DSpace__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int RebaseOriginDistance__Offset;
		/// <summary>Maximum distance to current view point where we should initiate origin rebasing</summary>
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
