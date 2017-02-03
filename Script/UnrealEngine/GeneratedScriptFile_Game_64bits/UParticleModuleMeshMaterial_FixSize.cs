#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleMeshMaterial
	{
		static readonly int MeshMaterials__Offset;
		public TObjectArray<UMaterialInterface>  MeshMaterials
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialInterface>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MeshMaterials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MeshMaterials__Offset, false);}
			
		}
		
		static UParticleModuleMeshMaterial()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleMeshMaterial");
			MeshMaterials__Offset=GetPropertyOffset(NativeClassPtr,"MeshMaterials");
			
		}
		
	}
	
}
#endif
#endif
