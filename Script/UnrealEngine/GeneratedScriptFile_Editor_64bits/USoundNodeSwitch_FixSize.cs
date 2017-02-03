#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Selects a child node based on the value of a integer parameter</summary>
	public partial class USoundNodeSwitch
	{
		static readonly int IntParameterName__Offset;
		/// <summary>The name of the integer parameter to use to determine which branch we should take</summary>
		public FName IntParameterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+IntParameterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IntParameterName__Offset, false);}
			
		}
		
		static USoundNodeSwitch()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeSwitch");
			IntParameterName__Offset=GetPropertyOffset(NativeClassPtr,"IntParameterName");
			
		}
		
	}
	
}
#endif
#endif
