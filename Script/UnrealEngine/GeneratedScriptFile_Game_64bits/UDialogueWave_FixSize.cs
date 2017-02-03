#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDialogueWave
	{
		static readonly int bMature__Offset;
		public bool bMature
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMature__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMature__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOverride_SubtitleOverride__Offset;
		public bool bOverride_SubtitleOverride
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_SubtitleOverride__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_SubtitleOverride__Offset, 1,0,2,2);}
			
		}
		
		static readonly int SpokenText__Offset;
		public FString SpokenText
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SpokenText__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpokenText__Offset, false);}
			
		}
		
		static readonly int SubtitleOverride__Offset;
		public FString SubtitleOverride
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SubtitleOverride__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubtitleOverride__Offset, false);}
			
		}
		
		static readonly int ContextMappings__Offset;
		public TStructArray<FDialogueContextMapping> ContextMappings
		{
			get{ CheckIsValid();return new TStructArray<FDialogueContextMapping>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ContextMappings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ContextMappings__Offset, false);}
			
		}
		
		static readonly int LocalizationGUID__Offset;
		public FGuid LocalizationGUID
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+LocalizationGUID__Offset, typeof(FGuid));}
			
		}
		
		static UDialogueWave()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DialogueWave");
			bMature__Offset=GetPropertyOffset(NativeClassPtr,"bMature");
			bOverride_SubtitleOverride__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_SubtitleOverride");
			SpokenText__Offset=GetPropertyOffset(NativeClassPtr,"SpokenText");
			SubtitleOverride__Offset=GetPropertyOffset(NativeClassPtr,"SubtitleOverride");
			ContextMappings__Offset=GetPropertyOffset(NativeClassPtr,"ContextMappings");
			LocalizationGUID__Offset=GetPropertyOffset(NativeClassPtr,"LocalizationGUID");
			
		}
		
	}
	
}
#endif
#endif
