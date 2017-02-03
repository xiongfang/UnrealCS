#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDialogueVoice
	{
		static readonly int Gender__Offset;
		public EGrammaticalGender Gender
		{
			get{ CheckIsValid();return (EGrammaticalGender)Marshal.PtrToStructure(_this.Get()+Gender__Offset, typeof(EGrammaticalGender));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Gender__Offset, false);}
			
		}
		
		static readonly int Plurality__Offset;
		public EGrammaticalNumber Plurality
		{
			get{ CheckIsValid();return (EGrammaticalNumber)Marshal.PtrToStructure(_this.Get()+Plurality__Offset, typeof(EGrammaticalNumber));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Plurality__Offset, false);}
			
		}
		
		static readonly int LocalizationGUID__Offset;
		public FGuid LocalizationGUID
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+LocalizationGUID__Offset, typeof(FGuid));}
			
		}
		
		static UDialogueVoice()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DialogueVoice");
			Gender__Offset=GetPropertyOffset(NativeClassPtr,"Gender");
			Plurality__Offset=GetPropertyOffset(NativeClassPtr,"Plurality");
			LocalizationGUID__Offset=GetPropertyOffset(NativeClassPtr,"LocalizationGUID");
			
		}
		
	}
	
}
#endif
#endif
