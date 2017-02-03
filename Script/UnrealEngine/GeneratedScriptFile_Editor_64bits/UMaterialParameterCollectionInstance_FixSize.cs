#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Class that stores per-world instance parameter data for a given UMaterialParameterCollection resource.
	/// Instances of this class are always transient.
	/// </summary>
	public partial class UMaterialParameterCollectionInstance
	{
		static readonly int Collection__Offset;
		/// <summary>Collection resource this instance is based off of.</summary>
		public UMaterialParameterCollection Collection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Collection__Offset); if (v == IntPtr.Zero)return null; UMaterialParameterCollection retValue = new UMaterialParameterCollection(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int World__Offset;
		/// <summary>World that owns this instance.</summary>
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
