#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackColorProp
	{
		static readonly int PropertyName__Offset;
		/// <summary>Name of property in Group  AActor  which this track mill modify over time.</summary>
		public FName PropertyName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PropertyName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PropertyName__Offset, false);}
			
		}
		
		static UInterpTrackColorProp()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackColorProp");
			PropertyName__Offset=GetPropertyOffset(NativeClassPtr,"PropertyName");
			
		}
		
	}
	
}
#endif
#endif
