#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Info is the base class of an Actor that isn't meant to have a physical representation in the world, used primarily
	/// for "manager" type classes that hold settings data about the world, but might need to be an Actor for replication purposes.
	/// </summary>
	public partial class AInfo
	{
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static AInfo()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Info");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			
		}
		
	}
	
}
#endif
#endif
