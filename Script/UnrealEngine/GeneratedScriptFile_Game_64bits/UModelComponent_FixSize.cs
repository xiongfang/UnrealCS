#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UModelComponent
	{
		static readonly int ModelBodySetup__Offset;
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
