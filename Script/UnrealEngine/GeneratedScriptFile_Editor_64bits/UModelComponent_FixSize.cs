#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// ModelComponents are PrimitiveComponents that represent elements of BSP geometry in a ULevel object.
	/// They are used exclusively by ULevel and are not intended as general-purpose components.
	/// @see ULevel
	/// </summary>
	public partial class UModelComponent
	{
		static readonly int ModelBodySetup__Offset;
		/// <summary>Description of collision</summary>
		public UBodySetup ModelBodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ModelBodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static UModelComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ModelComponent");
			ModelBodySetup__Offset=GetPropertyOffset(NativeClassPtr,"ModelBodySetup");
			
		}
		
	}
	
}
#endif
#endif
