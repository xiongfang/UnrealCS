#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A font face asset contains the raw payload data for a source TTF/OTF file as used by FreeType.
	/// During cook this asset type generates a ".ufont" file containing the raw payload data (unless loaded "Inline").
	/// </summary>
	public partial class UFontFace
	{
		static readonly int SourceFilename__Offset;
		/// <summary>The filename of the font face we were created from. This may not always exist on disk, as we may have previously loaded and cached the font data inside this asset.</summary>
		public FString SourceFilename
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFilename__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceFilename__Offset, false);}
			
		}
		
		static readonly int FontFaceData__Offset;
		/// <summary>The data associated with the font face. This should always be filled in providing the source filename is valid.</summary>
		public TStructArray<byte> FontFaceData
		{
			get{ CheckIsValid();return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FontFaceData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FontFaceData__Offset, false);}
			
		}
		
		static UFontFace()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("FontFace");
			SourceFilename__Offset=GetPropertyOffset(NativeClassPtr,"SourceFilename");
			FontFaceData__Offset=GetPropertyOffset(NativeClassPtr,"FontFaceData");
			
		}
		
	}
	
}
#endif
#endif
