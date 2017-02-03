#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneWidgetMaterialTrack
	{
		static readonly int BrushPropertyNamePath__Offset;
		public TStructArray<FName> BrushPropertyNamePath
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BrushPropertyNamePath__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BrushPropertyNamePath__Offset, false);}
			
		}
		
		static readonly int TrackName__Offset;
		public FName TrackName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+TrackName__Offset, typeof(FName));}
			
		}
		
		static UMovieSceneWidgetMaterialTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneWidgetMaterialTrack");
			BrushPropertyNamePath__Offset=GetPropertyOffset(NativeClassPtr,"BrushPropertyNamePath");
			TrackName__Offset=GetPropertyOffset(NativeClassPtr,"TrackName");
			
		}
		
	}
	
}
#endif
#endif
