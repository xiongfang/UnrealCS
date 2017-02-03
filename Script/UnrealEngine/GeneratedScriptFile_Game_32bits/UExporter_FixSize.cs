#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UExporter
	{
		static readonly int SupportedClass__Offset;
		public TSubclassOf<UObject>  SupportedClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SupportedClass__Offset); return v; }
			
		}
		
		static readonly int ExportRootScope__Offset;
		public UObject ExportRootScope
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ExportRootScope__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int FormatExtension__Offset;
		public TStructArray<FString> FormatExtension
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FormatExtension__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FormatExtension__Offset, false);}
			
		}
		
		static readonly int FormatDescription__Offset;
		public TStructArray<FString> FormatDescription
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FormatDescription__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FormatDescription__Offset, false);}
			
		}
		
		static readonly int PreferredFormatIndex__Offset;
		public int PreferredFormatIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreferredFormatIndex__Offset, typeof(int));}
			
		}
		
		static readonly int TextIndent__Offset;
		public int TextIndent
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TextIndent__Offset, typeof(int));}
			
		}
		
		static readonly int bText__Offset;
		public bool bText
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bText__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bSelectedOnly__Offset;
		public bool bSelectedOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSelectedOnly__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bForceFileOperations__Offset;
		public bool bForceFileOperations
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceFileOperations__Offset, 1, 0, 4, 4);}
			
		}
		
		static UExporter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Exporter");
			SupportedClass__Offset=GetPropertyOffset(NativeClassPtr,"SupportedClass");
			ExportRootScope__Offset=GetPropertyOffset(NativeClassPtr,"ExportRootScope");
			FormatExtension__Offset=GetPropertyOffset(NativeClassPtr,"FormatExtension");
			FormatDescription__Offset=GetPropertyOffset(NativeClassPtr,"FormatDescription");
			PreferredFormatIndex__Offset=GetPropertyOffset(NativeClassPtr,"PreferredFormatIndex");
			TextIndent__Offset=GetPropertyOffset(NativeClassPtr,"TextIndent");
			bText__Offset=GetPropertyOffset(NativeClassPtr,"bText");
			bSelectedOnly__Offset=GetPropertyOffset(NativeClassPtr,"bSelectedOnly");
			bForceFileOperations__Offset=GetPropertyOffset(NativeClassPtr,"bForceFileOperations");
			
		}
		
	}
	
}
#endif
#endif
