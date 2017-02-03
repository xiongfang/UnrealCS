#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A sphere generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
	public partial class USphereComponent
	{
		static readonly int SphereRadius__Offset;
		/// <summary>The radius of the sphere *</summary>
		public float SphereRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SphereRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SphereRadius__Offset, false);}
			
		}
		
		static USphereComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SphereComponent");
			SphereRadius__Offset=GetPropertyOffset(NativeClassPtr,"SphereRadius");
			
		}
		
	}
	
}
#endif
#endif
