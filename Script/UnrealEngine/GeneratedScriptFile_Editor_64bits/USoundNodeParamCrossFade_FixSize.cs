#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Crossfades between different sounds based on a parameter</summary>
	public partial class USoundNodeParamCrossFade
	{
		static readonly int ParamName__Offset;
		/// <summary>Parameter controlling cross fades.</summary>
		public FName ParamName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParamName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParamName__Offset, false);}
			
		}
		
		static USoundNodeParamCrossFade()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeParamCrossFade");
			ParamName__Offset=GetPropertyOffset(NativeClassPtr,"ParamName");
			
		}
		
	}
	
}
#endif
#endif
