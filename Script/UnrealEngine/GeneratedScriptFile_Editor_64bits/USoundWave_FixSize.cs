#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundWave
	{
		static readonly int CompressionQuality__Offset;
		/// <summary>Platform agnostic compression quality. 1..100 with 1 being best compression and 100 being best quality.</summary>
		public int CompressionQuality
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CompressionQuality__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompressionQuality__Offset, false);}
			
		}
		
		static readonly int bLooping__Offset;
		/// <summary>If set, when played directly (not through a sound cue) the wave will be played looping.</summary>
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLooping__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bStreaming__Offset;
		/// <summary>Whether this sound can be streamed to avoid increased memory usage</summary>
		public bool bStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStreaming__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStreaming__Offset, 1,0,2,2);}
			
		}
		
		static readonly int StreamingPriority__Offset;
		/// <summary>Priority of this sound when streaming (lower priority streams may not always play)</summary>
		public int StreamingPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+StreamingPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StreamingPriority__Offset, false);}
			
		}
		
		static readonly int bMature__Offset;
		/// <summary>If set to true if this sound is considered to contain mature/adult content.</summary>
		public bool bMature
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMature__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMature__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bManualWordWrap__Offset;
		/// <summary>If set to true will disable automatic generation of line breaks - use if the subtitles have been split manually.</summary>
		public bool bManualWordWrap
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bManualWordWrap__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bManualWordWrap__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bSingleLine__Offset;
		/// <summary>If set to true the subtitles display as a sequence of single lines as opposed to multiline.</summary>
		public bool bSingleLine
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSingleLine__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSingleLine__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bVirtualizeWhenSilent__Offset;
		/// <summary>Allows sound to play at 0 volume, otherwise will stop the sound when the sound is silent.</summary>
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
		/// <summary>A localized version of the text that is actually spoken phonetically in the audio.</summary>
		public FString SpokenText
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SpokenText__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpokenText__Offset, false);}
			
		}
		
		static readonly int SubtitlePriority__Offset;
		/// <summary>The priority of the subtitle.</summary>
		public float SubtitlePriority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SubtitlePriority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubtitlePriority__Offset, false);}
			
		}
		
		static readonly int Volume__Offset;
		/// <summary>Playback volume of sound 0 to 1 - Default is 1.0.</summary>
		public float Volume
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Volume__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Volume__Offset, false);}
			
		}
		
		static readonly int Pitch__Offset;
		/// <summary>Playback pitch for sound.</summary>
		public float Pitch
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Pitch__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Pitch__Offset, false);}
			
		}
		
		static readonly int NumChannels__Offset;
		/// <summary>Number of channels of multichannel data; 1 or 2 for regular mono and stereo files</summary>
		public int NumChannels
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumChannels__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumChannels__Offset, false);}
			
		}
		
		static readonly int SampleRate__Offset;
		/// <summary>Cached sample rate for displaying in the tools</summary>
		public int SampleRate
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SampleRate__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SampleRate__Offset, false);}
			
		}
		
		static readonly int ChannelOffsets__Offset;
		/// <summary>Offsets into the bulk data for the source wav data</summary>
		public TStructArray<int> ChannelOffsets
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChannelOffsets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChannelOffsets__Offset, false);}
			
		}
		
		static readonly int ChannelSizes__Offset;
		/// <summary>Sizes of the bulk data for the source wav data</summary>
		public TStructArray<int> ChannelSizes
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChannelSizes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChannelSizes__Offset, false);}
			
		}
		
		static readonly int RawPCMDataSize__Offset;
		/// <summary>Size of RawPCMData, or what RawPCMData would be if the sound was fully decompressed</summary>
		public int RawPCMDataSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RawPCMDataSize__Offset, typeof(int));}
			
		}
		
		static readonly int Subtitles__Offset;
		/// <summary>
		/// Subtitle cues.  If empty, use SpokenText as the subtitle.  Will often be empty,
		/// as the contents of the subtitle is commonly identical to what is spoken.
		/// </summary>
		public TStructArray<FSubtitleCue> Subtitles
		{
			get{ CheckIsValid();return new TStructArray<FSubtitleCue>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Subtitles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Subtitles__Offset, false);}
			
		}
		
		static readonly int Comment__Offset;
		/// <summary>Provides contextual information for the sound to the translator.</summary>
		public FString Comment
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Comment__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Comment__Offset, false);}
			
		}
		
		static readonly int LocalizedSubtitles__Offset;
		/// <summary>The array of the subtitles for each language. Generated at cook time.</summary>
		public TStructArray<FLocalizedSubtitle> LocalizedSubtitles
		{
			get{ CheckIsValid();return new TStructArray<FLocalizedSubtitle>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LocalizedSubtitles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LocalizedSubtitles__Offset, false);}
			
		}
		
		static readonly int SourceFilePath__Offset;
		public FString SourceFilePath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFilePath__Offset, typeof(FString));}
			
		}
		
		static readonly int SourceFileTimestamp__Offset;
		public FString SourceFileTimestamp
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFileTimestamp__Offset, typeof(FString));}
			
		}
		
		static readonly int AssetImportData__Offset;
		public UAssetImportData AssetImportData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AssetImportData__Offset); if (v == IntPtr.Zero)return null; UAssetImportData retValue = new UAssetImportData(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, value._this.Get()); }
			
		}
		
		static readonly int Curves__Offset;
		/// <summary>Curves associated with this sound wave</summary>
		public UCurveTable Curves
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Curves__Offset); if (v == IntPtr.Zero)return null; UCurveTable retValue = new UCurveTable(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Curves__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Curves__Offset, value._this.Get()); }
			
		}
		
		static readonly int InternalCurves__Offset;
		/// <summary>Hold a reference to our internal curve so we can switch back to it if we want to</summary>
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
			ChannelOffsets__Offset=GetPropertyOffset(NativeClassPtr,"ChannelOffsets");
			ChannelSizes__Offset=GetPropertyOffset(NativeClassPtr,"ChannelSizes");
			RawPCMDataSize__Offset=GetPropertyOffset(NativeClassPtr,"RawPCMDataSize");
			Subtitles__Offset=GetPropertyOffset(NativeClassPtr,"Subtitles");
			Comment__Offset=GetPropertyOffset(NativeClassPtr,"Comment");
			LocalizedSubtitles__Offset=GetPropertyOffset(NativeClassPtr,"LocalizedSubtitles");
			SourceFilePath__Offset=GetPropertyOffset(NativeClassPtr,"SourceFilePath");
			SourceFileTimestamp__Offset=GetPropertyOffset(NativeClassPtr,"SourceFileTimestamp");
			AssetImportData__Offset=GetPropertyOffset(NativeClassPtr,"AssetImportData");
			Curves__Offset=GetPropertyOffset(NativeClassPtr,"Curves");
			InternalCurves__Offset=GetPropertyOffset(NativeClassPtr,"InternalCurves");
			
		}
		
	}
	
}
#endif
#endif
