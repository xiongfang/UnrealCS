#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Structure containing all information related to an LOD group and providing helper functions to calculate
	/// the LOD bias of a given group.
	/// </summary>
	public partial class UTextureLODSettings
	{
		static readonly int TextureLODGroups__Offset;
		/// <summary>Array of LOD settings with entries per group.</summary>
		public TStructArray<FTextureLODGroup> TextureLODGroups
		{
			get{ CheckIsValid();return new TStructArray<FTextureLODGroup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TextureLODGroups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TextureLODGroups__Offset, false);}
			
		}
		
		static UTextureLODSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextureLODSettings");
			TextureLODGroups__Offset=GetPropertyOffset(NativeClassPtr,"TextureLODGroups");
			
		}
		
	}
	
}
#endif
#endif
