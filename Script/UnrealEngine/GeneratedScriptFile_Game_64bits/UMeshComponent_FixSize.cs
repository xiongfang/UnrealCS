#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMeshComponent
	{
		static readonly int OverrideMaterials__Offset;
		public TObjectArray<UMaterialInterface>  OverrideMaterials
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialInterface>((FScriptArray)Marshal.PtrToStructure(_this.Get()+OverrideMaterials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+OverrideMaterials__Offset, false);}
			
		}
		
		static UMeshComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MeshComponent");
			OverrideMaterials__Offset=GetPropertyOffset(NativeClassPtr,"OverrideMaterials");
			
		}
		
	}
	
}
#endif
#endif
