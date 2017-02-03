#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Selects a child node based on the value of a boolean parameter</summary>
	public partial class USoundNodeBranch
	{
		static readonly int BoolParameterName__Offset;
		/// <summary>The name of the boolean parameter to use to determine which branch we should take</summary>
		public FName BoolParameterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+BoolParameterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoolParameterName__Offset, false);}
			
		}
		
		static USoundNodeBranch()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeBranch");
			BoolParameterName__Offset=GetPropertyOffset(NativeClassPtr,"BoolParameterName");
			
		}
		
	}
	
}
#endif
#endif
