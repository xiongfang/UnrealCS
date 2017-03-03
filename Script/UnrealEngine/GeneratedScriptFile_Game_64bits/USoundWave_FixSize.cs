#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundWave
	{
		static readonly int CompressionQuality__Offset;
		public int CompressionQuality
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CompressionQuality__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompressionQuality__Offset, false);}
			
		}
		
		static readonly int bLooping__Offset;
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLooping__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bStreaming__Offset;
		public bool bStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStreaming__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStreaming__Offset, 1,0,2,2);}
			
		}
		
		static readonly int StreamingPriority__Offset;
		public int StreamingPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+StreamingPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StreamingPriority__Offset, false);}
			
		}
		
		static readonly int bMature__Offset;
		public bool bMature
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMature__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMature__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bManualWordWrap__Offset;
		public bool bManualWordWrap
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bManualWordWrap__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bManualWordWrap__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bSingleLine__Offset;
		public bool bSingleLine
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSingleLine__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSingleLine__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bVirtualizeWhenSilent__Offset;
		public bool bVirtualizeWhenSilent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVirtualizeWhenSilent__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVirtualizeWhenSilent__Offset, 1,0,64,64);}
			
		}
		
		static readonly int SoundGroup__Offset;
		public ESoundGroup SoundGroup
		{
			get{ CheckIsValid();return (ESoundGroup)Marshal.PtrToStructure(_this.Get()+SoundGroup__Offset, typeof(ESoundGroup));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SoundGroup__Offset, false);}
			
		}
		
		static readonly int SpokenText__Offset;
		public FString SpokenText
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SpokenText__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpokenText__Offset, false);}
			
		}
		
		static readonly int SubtitlePriority__Offset;
		public float SubtitlePriority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SubtitlePriority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubtitlePriority__Offset, false);}
			
		}
		
		static readonly int Volume__Offset;
		public float Volume
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Volume__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Volume__Offset, false);}
			
		}
		
		static readonly int Pitch__Offset;
		public float Pitch
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Pitch__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Pitch__Offset, false);}
			
		}
		
		static readonly int NumChannels__Offset;
		public int NumChannels
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumChannels__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumChannels__Offset, false);}
			
		}
		
		static readonly int SampleRate__Offset;
		public int SampleRate
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SampleRate__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SampleRate__Offset, false);}
			
		}
		
		static readonly int RawPCMDataSize__Offset;
		public int RawPCMDataSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RawPCMDataSize__Offset, typeof(int));}
			
		}
		
		static readonly int Subtitles__Offset;
		public TStructArray<FSubtitleCue> Subtitles
		{
			get{ CheckIsValid();return new TStructArray<FSubtitleCue>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Subtitles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Subtitles__Offset, false);}
			
		}
		
		static readonly int LocalizedSubtitles__Offset;
		public TStructArray<FLocalizedSubtitle> LocalizedSubtitles
		{
			get{ CheckIsValid();return new TStructArray<FLocalizedSubtitle>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LocalizedSubtitles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LocalizedSubtitles__Offset, false);}
			
		}
		
		static readonly int Curves__Offset;
		public UCurveTable Curves
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Curves__Offset); if (v == IntPtr.Zero)return null; UCurveTable retValue = new UCurveTable(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Curves__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Curves__Offset, value._this.Get()); }
			
		}
		
		static readonly int InternalCurves__Offset;
		public UCurveTable InternalCurves
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InternalCurves__Offset); if (v == IntPtr.Zero)return null; UCurveTable retValue = new UCurveTable(); retValue._this = v; return retValue; }
			
		}
		
		static USoundWave()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundWave");
			CompressionQuality__Offset=GetPropertyOffset(NativeClassPtr,"CompressionQuality");
			bLooping__Offset=GetPropertyOffset(NativeClassPtr,"bLooping");
			bStreaming__Offset=GetPropertyOffset(NativeClassPtr,"bStreaming");
			StreamingPriority__Offset=GetPropertyOffset(NativeClassPtr,"StreamingPriority");
			bMature__Offset=GetPropertyOffset(NativeClassPtr,"bMature");
			bManualWordWrap__Offset=GetPropertyOffset(NativeClassPtr,"bManualWordWrap");
			bSingleLine__Offset=GetPropertyOffset(NativeClassPtr,"bSingleLine");
			bVirtualizeWhenSilent__Offset=GetPropertyOffset(NativeClassPtr,"bVirtualizeWhenSilent");
			SoundGroup__Offset=GetPropertyOffset(NativeClassPtr,"SoundGroup");
			SpokenText__Offset=GetPropertyOffset(NativeClassPtr,"SpokenText");
			SubtitlePriority__Offset=GetPropertyOffset(NativeClassPtr,"SubtitlePriority");
			Volume__Offset=GetPropertyOffset(NativeClassPtr,"Volume");
			Pitch__Offset=GetPropertyOffset(NativeClassPtr,"Pitch");
			NumChannels__Offset=GetPropertyOffset(NativeClassPtr,"NumChannels");
			SampleRate__Offset=GetPropertyOffset(NativeClassPtr,"SampleRate");
			RawPCMDataSize__Offset=GetPropertyOffset(NativeClassPtr,"RawPCMDataSize");
			Subtitles__Offset=GetPropertyOffset(NativeClassPtr,"Subtitles");
			LocalizedSubtitles__Offset=GetPropertyOffset(NativeClassPtr,"LocalizedSubtitles");
			Curves__Offset=GetPropertyOffset(NativeClassPtr,"Curves");
			InternalCurves__Offset=GetPropertyOffset(NativeClassPtr,"InternalCurves");
			
		}
		
	}
	
}
#endif
#endif
