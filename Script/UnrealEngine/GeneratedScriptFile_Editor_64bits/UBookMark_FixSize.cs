#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A camera position the current level.</summary>
	public partial class UBookMark
	{
		static readonly int Location__Offset;
		/// <summary>Camera position</summary>
		public FVector Location
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Location__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Location__Offset, false);}
			
		}
		
		static readonly int Rotation__Offset;
		/// <summary>Camera rotation</summary>
		public FRotator Rotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+Rotation__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Rotation__Offset, false);}
			
		}
		
		static readonly int HiddenLevels__Offset;
		/// <summary>Array of levels that are hidden</summary>
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
