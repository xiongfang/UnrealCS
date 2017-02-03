#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTimelineTemplate
	{
		static readonly int TimelineLength__Offset;
		/// <summary>Length of this timeline</summary>
		public float TimelineLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimelineLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimelineLength__Offset, false);}
			
		}
		
		static readonly int LengthMode__Offset;
		/// <summary>How we want the timeline to determine its own length (e.g. specified length, last keyframe)</summary>
		public ETimelineLengthMode LengthMode
		{
			get{ CheckIsValid();return (ETimelineLengthMode)Marshal.PtrToStructure(_this.Get()+LengthMode__Offset, typeof(ETimelineLengthMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LengthMode__Offset, false);}
			
		}
		
		static readonly int bAutoPlay__Offset;
		/// <summary>If we want the timeline to auto-play</summary>
		public bool bAutoPlay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoPlay__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoPlay__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bLoop__Offset;
		/// <summary>If we want the timeline to loop</summary>
		public bool bLoop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoop__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoop__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bReplicated__Offset;
		/// <summary>If we want the timeline to loop</summary>
		public bool bReplicated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicated__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReplicated__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bValidatedAsWired__Offset;
		/// <summary>Compiler Validated As Wired up</summary>
		public bool bValidatedAsWired
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bValidatedAsWired__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bIgnoreTimeDilation__Offset;
		/// <summary>If we want the timeline to ignore global time dilation</summary>
		public bool bIgnoreTimeDilation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreTimeDilation__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreTimeDilation__Offset, 1,0,16,16);}
			
		}
		
		static readonly int EventTracks__Offset;
		/// <summary>Set of event tracks</summary>
		public TStructArray<FTTEventTrack> EventTracks
		{
			get{ CheckIsValid();return new TStructArray<FTTEventTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EventTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EventTracks__Offset, false);}
			
		}
		
		static readonly int FloatTracks__Offset;
		/// <summary>Set of float interpolation tracks</summary>
		public TStructArray<FTTFloatTrack> FloatTracks
		{
			get{ CheckIsValid();return new TStructArray<FTTFloatTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FloatTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FloatTracks__Offset, false);}
			
		}
		
		static readonly int VectorTracks__Offset;
		/// <summary>Set of vector interpolation tracks</summary>
		public TStructArray<FTTVectorTrack> VectorTracks
		{
			get{ CheckIsValid();return new TStructArray<FTTVectorTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VectorTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VectorTracks__Offset, false);}
			
		}
		
		static readonly int LinearColorTracks__Offset;
		/// <summary>Set of linear color interpolation tracks</summary>
		public TStructArray<FTTLinearColorTrack> LinearColorTracks
		{
			get{ CheckIsValid();return new TStructArray<FTTLinearColorTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LinearColorTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LinearColorTracks__Offset, false);}
			
		}
		
		static readonly int MetaDataArray__Offset;
		/// <summary>Metadata information for this timeline</summary>
		public TStructArray<FBPVariableMetaDataEntry> MetaDataArray
		{
			get{ CheckIsValid();return new TStructArray<FBPVariableMetaDataEntry>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MetaDataArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MetaDataArray__Offset, false);}
			
		}
		
		static readonly int TimelineGuid__Offset;
		public FGuid TimelineGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+TimelineGuid__Offset, typeof(FGuid));}
			
		}
		
		static UTimelineTemplate()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TimelineTemplate");
			TimelineLength__Offset=GetPropertyOffset(NativeClassPtr,"TimelineLength");
			LengthMode__Offset=GetPropertyOffset(NativeClassPtr,"LengthMode");
			bAutoPlay__Offset=GetPropertyOffset(NativeClassPtr,"bAutoPlay");
			bLoop__Offset=GetPropertyOffset(NativeClassPtr,"bLoop");
			bReplicated__Offset=GetPropertyOffset(NativeClassPtr,"bReplicated");
			bValidatedAsWired__Offset=GetPropertyOffset(NativeClassPtr,"bValidatedAsWired");
			bIgnoreTimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreTimeDilation");
			EventTracks__Offset=GetPropertyOffset(NativeClassPtr,"EventTracks");
			FloatTracks__Offset=GetPropertyOffset(NativeClassPtr,"FloatTracks");
			VectorTracks__Offset=GetPropertyOffset(NativeClassPtr,"VectorTracks");
			LinearColorTracks__Offset=GetPropertyOffset(NativeClassPtr,"LinearColorTracks");
			MetaDataArray__Offset=GetPropertyOffset(NativeClassPtr,"MetaDataArray");
			TimelineGuid__Offset=GetPropertyOffset(NativeClassPtr,"TimelineGuid");
			
		}
		
	}
	
}
#endif
#endif
