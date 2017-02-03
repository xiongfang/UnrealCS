#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A material track which is specialized for materials which are owned by widget brushes.</summary>
	public partial class UMovieSceneWidgetMaterialTrack
	{
		static readonly int BrushPropertyNamePath__Offset;
		/// <summary>The name of the brush property which will be animated by this track.</summary>
		public TStructArray<FName> BrushPropertyNamePath
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BrushPropertyNamePath__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BrushPropertyNamePath__Offset, false);}
			
		}
		
		static readonly int TrackName__Offset;
		/// <summary>The name of this track, generated from the property name path.</summary>
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
