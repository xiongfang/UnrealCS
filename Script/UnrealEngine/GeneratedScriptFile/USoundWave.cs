using System;
namespace UnrealEngine
{
	public partial class USoundWave:USoundBase
	{
		/// <summary>Platform agnostic compression quality. 1..100 with 1 being best compression and 100 being best quality.</summary>
		public int CompressionQuality;
		
		/// <summary>If set, when played directly (not through a sound cue) the wave will be played looping.</summary>
		public bool bLooping;
		
		/// <summary>Whether this sound can be streamed to avoid increased memory usage</summary>
		public bool bStreaming;
		
		/// <summary>Priority of this sound when streaming (lower priority streams may not always play)</summary>
		public int StreamingPriority;
		
		/// <summary>If set to true if this sound is considered to contain mature/adult content.</summary>
		public bool bMature;
		
		/// <summary>If set to true will disable automatic generation of line breaks - use if the subtitles have been split manually.</summary>
		public bool bManualWordWrap;
		
		/// <summary>If set to true the subtitles display as a sequence of single lines as opposed to multiline.</summary>
		public bool bSingleLine;
		
		/// <summary>Allows sound to play at 0 volume, otherwise will stop the sound when the sound is silent.</summary>
		public bool bVirtualizeWhenSilent;
		
		public ESoundGroup SoundGroup;
		
		/// <summary>A localized version of the text that is actually spoken phonetically in the audio.</summary>
		public FString SpokenText;
		
		/// <summary>The priority of the subtitle.</summary>
		public float SubtitlePriority;
		
		/// <summary>Playback volume of sound 0 to 1 - Default is 1.0.</summary>
		public float Volume;
		
		/// <summary>Playback pitch for sound.</summary>
		public float Pitch;
		
		/// <summary>Number of channels of multichannel data; 1 or 2 for regular mono and stereo files</summary>
		public int NumChannels;
		
		/// <summary>Cached sample rate for displaying in the tools</summary>
		public int SampleRate;
		
		/// <summary>Size of RawPCMData, or what RawPCMData would be if the sound was fully decompressed</summary>
		public int RawPCMDataSize;
		
		/// <summary>Provides contextual information for the sound to the translator.</summary>
		public FString Comment;
		
		public FString SourceFilePath;
		
		public FString SourceFileTimestamp;
		
		public UAssetImportData AssetImportData;
		
		/// <summary>Curves associated with this sound wave</summary>
		public UCurveTable Curves;
		
		/// <summary>Hold a reference to our internal curve so we can switch back to it if we want to</summary>
		public UCurveTable InternalCurves;
		
		
	}
	
}
