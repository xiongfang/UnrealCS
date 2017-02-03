#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBookMark
	{
		static readonly int Location__Offset;
		public FVector Location
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Location__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Location__Offset, false);}
			
		}
		
		static readonly int Rotation__Offset;
		public FRotator Rotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+Rotation__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Rotation__Offset, false);}
			
		}
		
		static readonly int HiddenLevels__Offset;
		public TStructArray<FString> HiddenLevels
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HiddenLevels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HiddenLevels__Offset, false);}
			
		}
		
		static UBookMark()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BookMark");
			Location__Offset=GetPropertyOffset(NativeClassPtr,"Location");
			Rotation__Offset=GetPropertyOffset(NativeClassPtr,"Rotation");
			HiddenLevels__Offset=GetPropertyOffset(NativeClassPtr,"HiddenLevels");
			
		}
		
	}
	
}
#endif
#endif
