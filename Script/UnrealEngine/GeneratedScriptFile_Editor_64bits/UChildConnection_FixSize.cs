#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents a secondary split screen connection that reroutes calls to the parent connection.</summary>
	public partial class UChildConnection
	{
		static readonly int Parent__Offset;
		public UNetConnection Parent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Parent__Offset); if (v == IntPtr.Zero)return null; UNetConnection retValue = new UNetConnection(); retValue._this = v; return retValue; }
			
		}
		
		static UChildConnection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ChildConnection");
			Parent__Offset=GetPropertyOffset(NativeClassPtr,"Parent");
			
		}
		
	}
	
}
#endif
#endif
