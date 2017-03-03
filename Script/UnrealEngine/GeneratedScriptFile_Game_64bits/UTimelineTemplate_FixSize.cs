#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTimelineTemplate
	{
		static readonly int TimelineLength__Offset;
		public float TimelineLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimelineLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimelineLength__Offset, false);}
			
		}
		
		static readonly int LengthMode__Offset;
		public ETimelineLengthMode LengthMode
		{
			get{ CheckIsValid();return (ETimelineLengthMode)Marshal.PtrToStructure(_this.Get()+LengthMode__Offset, typeof(ETimelineLengthMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LengthMode__Offset, false);}
			
		}
		
		static readonly int bAutoPlay__Offset;
		public bool bAutoPlay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoPlay__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoPlay__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bLoop__Offset;
		public bool bLoop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoop__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoop__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bReplicated__Offset;
		public bool bReplicated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicated__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReplicated__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bValidatedAsWired__Offset;
		public bool bValidatedAsWired
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bValidatedAsWired__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bIgnoreTimeDilation__Offset;
		public bool bIgnoreTimeDilation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreTimeDilation__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreTimeDilation__Offset, 1,0,16,16);}
			
		}
		
		static readonly int EventTracks__Offset;
		public TStructArray<FTTEventTrack> EventTracks
		{
			get{ CheckIsValid();return new TStructArray<FTTEventTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EventTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EventTracks__Offset, false);}
			
		}
		
		static readonly int FloatTracks__Offset;
		public TStructArray<FTTFloatTrack> FloatTracks
		{
			get{ CheckIsValid();return new TStructArray<FTTFloatTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FloatTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FloatTracks__Offset, false);}
			
		}
		
		static readonly int VectorTracks__Offset;
		public TStructArray<FTTVectorTrack> VectorTracks
		{
			get{ CheckIsValid();return new TStructArray<FTTVectorTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VectorTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VectorTracks__Offset, false);}
			
		}
		
		static readonly int LinearColorTracks__Offset;
		public TStructArray<FTTLinearColorTrack> LinearColorTracks
		{
			get{ CheckIsValid();return new TStructArray<FTTLinearColorTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LinearColorTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LinearColorTracks__Offset, false);}
			
		}
		
		static readonly int MetaDataArray__Offset;
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
