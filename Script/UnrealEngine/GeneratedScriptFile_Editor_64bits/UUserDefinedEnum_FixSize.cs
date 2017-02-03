#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>An Enumeration is a list of named values.</summary>
	public partial class UUserDefinedEnum
	{
		static readonly int UniqueNameIndex__Offset;
		public uint UniqueNameIndex
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+UniqueNameIndex__Offset, typeof(uint));}
			
		}
		
		static readonly int DisplayNames__Offset;
		/// <summary>
		/// Names stored in "DisplayName" meta data. They are duplicated here,
		/// so functions like UKismetNodeHelperLibrary::GetEnumeratorUserFriendlyName can use them
		/// outside the editor. (When meta data are not loaded).
		/// To sync DisplayNames with meta-data use FEnumEditorUtils::EnsureAllDisplayNamesExist.
		/// </summary>
		public TStructArray<FText> DisplayNames
		{
			get{ CheckIsValid();return new TStructArray<FText>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DisplayNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DisplayNames__Offset, false);}
			
		}
		
		static UUserDefinedEnum()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UserDefinedEnum");
			UniqueNameIndex__Offset=GetPropertyOffset(NativeClassPtr,"UniqueNameIndex");
			DisplayNames__Offset=GetPropertyOffset(NativeClassPtr,"DisplayNames");
			
		}
		
	}
	
}
#endif
#endif
