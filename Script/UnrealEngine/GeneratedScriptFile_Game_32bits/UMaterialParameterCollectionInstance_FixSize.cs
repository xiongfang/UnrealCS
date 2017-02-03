#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialParameterCollectionInstance
	{
		static readonly int Collection__Offset;
		public UMaterialParameterCollection Collection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Collection__Offset); if (v == IntPtr.Zero)return null; UMaterialParameterCollection retValue = new UMaterialParameterCollection(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int World__Offset;
		public UWorld World
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + World__Offset); if (v == IntPtr.Zero)return null; UWorld retValue = new UWorld(); retValue._this = v; return retValue; }
			
		}
		
		static UMaterialParameterCollectionInstance()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialParameterCollectionInstance");
			Collection__Offset=GetPropertyOffset(NativeClassPtr,"Collection");
			World__Offset=GetPropertyOffset(NativeClassPtr,"World");
			
		}
		
	}
	
}
#endif
#endif
