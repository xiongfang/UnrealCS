#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UFontFace
	{
		static readonly int SourceFilename__Offset;
		public FString SourceFilename
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFilename__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceFilename__Offset, false);}
			
		}
		
		static UFontFace()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("FontFace");
			SourceFilename__Offset=GetPropertyOffset(NativeClassPtr,"SourceFilename");
			
		}
		
	}
	
}
#endif
#endif
