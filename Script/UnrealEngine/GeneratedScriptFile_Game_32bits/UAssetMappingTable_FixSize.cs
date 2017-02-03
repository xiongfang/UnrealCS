#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAssetMappingTable
	{
		static readonly int MappedAssets__Offset;
		public TStructArray<FAssetMapping> MappedAssets
		{
			get{ CheckIsValid();return new TStructArray<FAssetMapping>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MappedAssets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MappedAssets__Offset, false);}
			
		}
		
		static UAssetMappingTable()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AssetMappingTable");
			MappedAssets__Offset=GetPropertyOffset(NativeClassPtr,"MappedAssets");
			
		}
		
	}
	
}
#endif
#endif
